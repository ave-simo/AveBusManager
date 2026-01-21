using System;

namespace AveBusManager
{
    internal class CLI
    {

        sbyte UPPER_BOUND = 0;
        sbyte LOWER_BOUND = 2;
        AveBusController AveBusController;

        public CLI(AveBusController aveBusController)
        {
            this.AveBusController = aveBusController;
        }

        public void startCLI()
        {

            // menu initialization
            ConsoleKey pressedKey;
            sbyte currentSelection = 0; // initial cursor position = 0

            Console.Clear();
            printMenu(currentSelection);


            // menu 
            while (true)
            {
                pressedKey = Console.ReadKey(true).Key;

                // increase or decrease current selection
                if (pressedKey.Equals(ConsoleKey.UpArrow) && currentSelection > UPPER_BOUND)
                {
                    Console.Clear();

                    currentSelection--;
                    printMenu(currentSelection);
                }

                if (pressedKey.Equals(ConsoleKey.DownArrow) && currentSelection < LOWER_BOUND)
                {
                    Console.Clear();

                    currentSelection++;
                    printMenu(currentSelection);
                }

                // sends command on avebus
                if (pressedKey.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    performActionOnAveBus(currentSelection);

                }

                if (pressedKey.Equals(ConsoleKey.Escape))
                {
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    return;

                }
            }

        }

        private void performActionOnAveBus(sbyte currentSelection)
        {
            switch (currentSelection)
            {
                case 0:
                    AveBusController.changeLight1Status();
                    break;

                case 1:
                    AveBusController.turnOnLight_1();
                    break;

                case 2:
                    AveBusController.turnOffLight_1();
                    break;
                default:
                    Console.WriteLine("how did you even press that");
                    return;
            }
        }

        private void printMenu(sbyte currentSelection)
        {

            if(currentSelection == 0)
            {
                Console.WriteLine("AveBusManager:");
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("| > CHANGE LIGHT 1 STATUS |");
                Console.WriteLine("| TURN ON  LIGHT 1        |");
                Console.WriteLine("| TURN OFF LIGHT 1        |");
                Console.WriteLine("+-------------------------+");
            }

            if (currentSelection == 1)
            {
                Console.WriteLine("AveBusManager:");
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("| CHANGE LIGHT 1 STATUS   |");
                Console.WriteLine("| > TURN ON  LIGHT 1      |");
                Console.WriteLine("| TURN OFF LIGHT 1        |");
                Console.WriteLine("+-------------------------+");
            }

            if (currentSelection == 2)
            {
                Console.WriteLine("AveBusManager:");
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("| CHANGE LIGHT 1 STATUS   |");
                Console.WriteLine("| TURN ON  LIGHT 1        |");
                Console.WriteLine("| > TURN OFF LIGHT 1      |");
                Console.WriteLine("+-------------------------+");
            }

        }
    }

}
