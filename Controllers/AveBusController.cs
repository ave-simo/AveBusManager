using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace AveBusManager
{
    internal class AveBusController
    {
        private SerialPort serialPort = new SerialPort();

        private bool read = false;
        private Thread readBusThread;
        private Thread readKeyboardThread;

        public event Action<string, string> busEvent;

        private static byte[] CHANGE_LIGHT_STATUS_FRAME_COMMAND = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x02, 0xFA, 0xEA };
        private static byte[] TURN_ON_LIGHT_1_FRAME_COMMAND     = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x01, 0xFA, 0xE9 };
        private static byte[] TURN_OFF_LIGHT_1_FRAME_COMMAND    = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x03, 0xFA, 0xEB };
        private static byte[] TURN_ON_LIGHT_2_FRAME_COMMAND     = new byte[] { 0x40, 0x07, 0x26, 0x26, 0x4E, 0x01, 0xFA, 0xE7 };
        private static byte[] TURN_OFF_LIGHT_2_FRAME_COMMAND    = new byte[] { 0x40, 0x07, 0x26, 0x26, 0x4E, 0x03, 0xFA, 0xE9 };



        public AveBusController()
        {
            // init keyboard loop
            readKeyboardThread = new Thread(readKeyboardLoop);
            readKeyboardThread.Start();
            Console.WriteLine("started reading keyboard");
            Console.WriteLine("Press R, G, or B to change Background color.");
            Console.WriteLine("Press D to restore default color.");
        }



        // ==============================================================
        // getters and setters
        public SerialPort getSerialPort()
        {
            return serialPort;
        }



        // ==============================================================
        // methods to interact with ports
        public string[] getAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }
        public void configureSerialPort(string portName, int baudRate, Parity parity, sbyte databits, StopBits stopBits, Handshake handShake)
        {
            try
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.Parity = parity;
                serialPort.DataBits = databits;
                serialPort.StopBits = stopBits;
                serialPort.Handshake = handShake;

                Console.WriteLine("port " + serialPort.PortName + " configured successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: ");
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public void openSerialPort()
        {

            try
            {
                serialPort.Open();
                Console.WriteLine("port " + serialPort.PortName + " opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: ");
                Console.WriteLine(ex.Message);
                return;
            }
            
        }



        // ==============================================================
        // methods to write in avebus
        public void changeLight1Status() 
        { 
            sendCommand(CHANGE_LIGHT_STATUS_FRAME_COMMAND);
            Console.WriteLine("command [CHANGE_LIGHT_STATUS_FRAME_COMMAND] sent.");

        }
        public void turnOnLight_1()
        {
            sendCommand(TURN_ON_LIGHT_1_FRAME_COMMAND);
            Console.WriteLine("command [TURN_ON_LIGHT_1_FRAME_COMMAND] sent.");
        }
        public void turnOffLight_1()
        {
            sendCommand(TURN_OFF_LIGHT_1_FRAME_COMMAND);
            Console.WriteLine("command [TURN_OFF_LIGHT_1_FRAME_COMMAND] sent.");
        }
        public void turnOnLight_2()
        {
            sendCommand(TURN_ON_LIGHT_2_FRAME_COMMAND);
            Console.WriteLine("command [TURN_ON_LIGHT_2_FRAME_COMMAND] sent.");
        }
        public void turnOffLight_2()
        {
            sendCommand(TURN_OFF_LIGHT_2_FRAME_COMMAND);
            Console.WriteLine("command [TURN_OFF_LIGHT_2_FRAME_COMMAND] sent.");
        }
        private byte[] bitwiseNot(byte[] command)
        {
            byte[] bitwiseInvertedCommand = new byte[command.Length];

            for (int i = 0; i < command.Length; i++)
            {
                bitwiseInvertedCommand[i] = (byte)~command[i];
            }
            return bitwiseInvertedCommand;
        }

        // actually send frame in AveBus
        private void sendCommand(byte[] command)
        {
            try
            {
                serialPort.Write(bitwiseNot(command), 0, command.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: ");
                Console.WriteLine(ex.Message);
                return;
            }

        }



        // ==============================================================
        // Non blocking keyboard
        private void readKeyboardLoop()
        {

            ConsoleKey pressedKey;

            while (true)
            {
                //Console.Write(".");
                if (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey(true).Key; //bloccante

                    if (pressedKey.Equals(ConsoleKey.R)) busEvent?.Invoke("CHANGE_BACKGROUND_COLOR", "red");
                    if (pressedKey.Equals(ConsoleKey.G)) busEvent?.Invoke("CHANGE_BACKGROUND_COLOR", "green");
                    if (pressedKey.Equals(ConsoleKey.B)) busEvent?.Invoke("CHANGE_BACKGROUND_COLOR", "blue");
                    if (pressedKey.Equals(ConsoleKey.D)) busEvent?.Invoke("CHANGE_BACKGROUND_COLOR", "default");
                }

                Thread.Sleep(100);

            }
        }



        // ==============================================================
        // methods to read from avebus
        public void startReadingBus()
        {
            // evita doppio start
            if (readBusThread != null && readBusThread.IsAlive)
                return;

            read = true;
            readBusThread = new Thread(readBusLoop);
            readBusThread.Start();
            Console.WriteLine("started reading AveBus interface");
        }

        public void stopReadingBus()
        {
            this.read = false;
            Console.WriteLine("stopped reading AveBus interface");
        }

        public void readBusLoopNEW()
        {

            serialPort.DiscardInBuffer();

            while (read)
            {
                if (serialPort.BytesToRead >= 2) //PEEK
                {
                    byte[] firstTwoBytes = new byte[2];
                    serialPort.Read(firstTwoBytes, 0, firstTwoBytes.Length);

                    int completePackLength = (byte)((~firstTwoBytes[1] & 0x1F) + 1);

                    if (completePackLength > 2)
                    {
                        int totalCounterOfBytesToRead = completePackLength - firstTwoBytes.Length;

                        byte[] remainingBytes = new byte[completePackLength - 2];
                        int countOfBytesEffectivelyRead = 0;

                        int portionLength = 0;
                        int portionRemainingBytesToRead = totalCounterOfBytesToRead;

                        while (portionRemainingBytesToRead > 0)
                        {
                            portionLength = serialPort.Read(remainingBytes, countOfBytesEffectivelyRead, portionRemainingBytesToRead);
                            countOfBytesEffectivelyRead += portionLength;
                            portionRemainingBytesToRead -= portionLength;
                            Thread.Sleep(50);
                        }

                        if (countOfBytesEffectivelyRead == remainingBytes.Length)
                        {
                            byte[] completeFrame = new byte[completePackLength];
                            Array.Copy(firstTwoBytes, 0, completeFrame, 0, firstTwoBytes.Length);
                            Array.Copy(remainingBytes, 0, completeFrame, firstTwoBytes.Length, remainingBytes.Length);

                            String stringa = "";
                            int i = 0;
                            for (i = 0; i < completeFrame.Length; i++)
                            {
                                completeFrame[i] = (byte)(~completeFrame[i]);
                                stringa += completeFrame[i].ToString("X2") + " ";
                            }

                            busEvent?.Invoke("PRINT_LOG", "[ " + stringa + "]");
                            busEvent?.Invoke("PRINT_LOG", Environment.NewLine);

                            updateLightsIndicators(stringa);

                        }
                    }
                }
                Thread.Sleep(50);
            }
        }

        private void updateLightsIndicators(string message)
        {
            message = message.Trim();

            if(message.Equals("40 07 27 27 4E 01 FA E9".Trim())) busEvent?.Invoke("LIGHT_STATUS", "TURN_ON_LIGHT_1_FRAME_COMMAND");
            if(message.Equals("40 07 27 27 4E 03 FA EB".Trim())) busEvent?.Invoke("LIGHT_STATUS", "TURN_OFF_LIGHT_1_FRAME_COMMAND");
            if(message.Equals("40 07 26 26 4E 01 FA E7".Trim())) busEvent?.Invoke("LIGHT_STATUS", "TURN_ON_LIGHT_2_FRAME_COMMAND");
            if(message.Equals("40 07 26 26 4E 03 FA E9".Trim())) busEvent?.Invoke("LIGHT_STATUS", "TURN_OFF_LIGHT_2_FRAME_COMMAND");
            if(message.Equals("40 07 27 27 4E 02 FA EA".Trim())) { }
        }

        private void readBusLoop()
        {
            serialPort.DiscardInBuffer();

            byte[] firstTwoBytesBuf = new byte[2];
            byte[] msgBuf;
            int len;

            while (read)
            {
                // PEEK
                if (serialPort.BytesToRead < 2)
                {
                    Thread.Sleep(50);
                    continue;
                }
                
                serialPort.Read(firstTwoBytesBuf, 0, 2);         // leggo i primi due byte
                len = (byte)((~firstTwoBytesBuf[1] & 0x1F) + 1); // calcolo lunghezza pacchetto

                // frame sporco
                if (len < 7 || len > 32)
                {
                    serialPort.DiscardInBuffer();
                    continue;
                }

                msgBuf = new byte[len];

                // copio i primi due byte
                msgBuf[0] = firstTwoBytesBuf[0];
                msgBuf[1] = firstTwoBytesBuf[1];

                int remaining = len - 2;   // byte ancora da leggere
                int offset = 2;            // dove scrivere nel buffer

                // leggo bytes rimanenti
                while (remaining > 0)
                {
                    int readNow = serialPort.Read(msgBuf, offset, remaining);
                    offset += readNow;
                    remaining -= readNow;
                    Thread.Sleep(50);
                }

                // messaggio completo
                string message = "";
                for (int i = 0; i < msgBuf.Length; i++)
                {
                    msgBuf[i] = (byte)~msgBuf[i];
                    message += msgBuf[i].ToString("X2") + " ";
                }

                busEvent?.Invoke("PRINT_LOG", "[ " + message + "]" + Environment.NewLine);
                updateLightsIndicators(message);
            }
        }



    }

}
