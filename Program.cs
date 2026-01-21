using System;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;

namespace AveBusManager
{
    internal class Program
    {
        static string PORT = "COM3";

        static void Main(string[] args)
        {

            if (args.Length > 0 && args.Contains("--cli"))
            {
                // starts CLI
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

                CLI cli = new CLI(aveBusController);
                cli.startCLI();
            } else
            {
                // starts GUI
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }

        }
    }
}
