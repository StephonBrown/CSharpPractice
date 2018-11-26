using System;
namespace ImprovedFactorizor.UI
{
    public static class ConsoleInput
    {
        public static int GetUserInput()
        {
            string input;
            int output;

            while (true)
            {
                Console.WriteLine("Please input a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    return output;
                }

                Console.WriteLine("This is not a valid input.");
                Console.ReadKey();
            }

        }

        public static bool GetUserStringInput()
        {
            Console.WriteLine("Would you like to try another number(y): ");
            string input = Console.ReadLine();

            if (input.ToLower().Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
