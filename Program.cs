using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AveBusManager
{
    internal class Program
    {
        static string PORT = "COM3";

        static void Main(string[] args)
        {

            AveBusController aveBusController = new AveBusController();

            aveBusController.configureSerialPort(
                PORT,
                4800,
                Parity.Odd,
                8,
                StopBits.One,
                Handshake.None
            );

            aveBusController.openSerialPort();
            Console.WriteLine("Successfully estabilished connection with AveBus.\n");

            Console.WriteLine("Starting CLI...");
            Console.WriteLine("Press UP and DOWN arrows + ENTER to perform selection");
            Console.WriteLine("Press ESC to exit.");

            System.Threading.Thread.Sleep(1500);

            if (args.Length > 0 && args.Contains("--cli"))
            {
                CLI cli = new CLI(aveBusController);
                cli.startCLI();
            }

        }
    }
}
