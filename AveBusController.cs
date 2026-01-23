using System;
using System.IO.Ports;

namespace AveBusManager
{
    internal class AveBusController
    {
        private SerialPort serialPort = new SerialPort();

        // TODO: spostare in una classe enum che contenga solamente comandi
        private static byte[] CHANGE_LIGHT_STATUS_FRAME_COMMAND = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x02, 0xFA, 0xEA };
        private static byte[] TURN_ON_LIGHT_1_FRAME_COMMAND     = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x01, 0xFA, 0xE9 };
        private static byte[] TURN_OFF_LIGHT_1_FRAME_COMMAND    = new byte[] { 0x40, 0x07, 0x27, 0x27, 0x4E, 0x03, 0xFA, 0xEB };



        // ==============================================================
        // methods to interact with ports
        public SerialPort getSerialPort()
        {
            return serialPort;
        }
        public string[] getAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }
        public void configureSerialPort(string portName, int baudRate, Parity parity, sbyte databits, StopBits stopBits, Handshake handShake)
        {
            try
            {
                this.serialPort.PortName = portName;
                this.serialPort.BaudRate = baudRate;
                this.serialPort.Parity = parity;
                this.serialPort.DataBits = databits;
                this.serialPort.StopBits = stopBits;
                this.serialPort.Handshake = handShake;

                Console.WriteLine("port " + serialPort.PortName + " configured successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Error: \n");
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
                Console.WriteLine("Something went wrong. Error: \n");
                Console.WriteLine(ex.Message);
                return;
            }
            
        }



        // ==============================================================
        // methods to interact with avebus
        // (add here your new methods)
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
                Console.WriteLine("Something went wrong. Error: \n");
                Console.WriteLine(ex.Message);
                return;
            }

        }

    }
}
