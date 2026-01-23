using System;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;

namespace AveBusManager
{
    internal class Program
    {
        static string PORT = "COM3"; // default port for cli interface

        [STAThread] //thread principale
        static void Main(string[] args)
        { 

            if (args.Length > 0 && args.Contains("--cli"))
            {
                // starts CLI
                cliStartProcedure();
            } else
            {
                // starts GUI
                guiStartProcedure();
            }

        }

        private static void cliStartProcedure()
        {
            AveBusController aveBusController = new AveBusController();

            if (!aveBusController.getAvailablePorts().Contains(PORT))
            {
                Console.WriteLine("Port [" + PORT + "] is not available. Exiting.");
                return;
            }

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

        }

        private static void guiStartProcedure()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
