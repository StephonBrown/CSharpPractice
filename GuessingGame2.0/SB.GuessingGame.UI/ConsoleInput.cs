using System;
namespace SB.GuessingGame.UI
{
    public class ConsoleInput
    {
        public static int GetGuessFromUser()
        {
            Console.Clear();
            string userInput;
            int output;

            while (true)
            {
                Console.Write("Enter a guess between 1 and 20");
                userInput = Console.ReadLine();

                if(int.TryParse(userInput, out output))
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("That was not a valid number! Press any key to continue...");
                    Console.ReadKey();
                }

            }

        }
    }
}
