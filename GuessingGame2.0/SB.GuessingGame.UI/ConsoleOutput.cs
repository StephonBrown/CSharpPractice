using System;
using GuessingGame.BLL;

namespace SB.GuessingGame.UI
{
    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better version 2.0 of the Guessing Game!\n\n");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();

        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            switch(result)
            {
                case GuessResult.Invalid:
                    DisplayInvalid();
                    break;
                case GuessResult.Higher:
                    DisplayHigher();
                    break;
                case GuessResult.Lower:
                    DisplayLower();
                    break;
                case GuessResult.Victory:
                    DisplayVictory();
                    break;
            }
        }

        private static void DisplayVictory()
        {
            Console.WriteLine("You did it! You are awesome!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private static void DisplayHigher()
        {
            Console.WriteLine("Your guess was to low, try again!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private static void DisplayLower()
        {
            Console.WriteLine("Your guess was to high, try again!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private static void DisplayInvalid()
        {
            Console.WriteLine("Your guess was invalid, try something between 1 and 20");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
