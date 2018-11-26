using System;
namespace ImprovedFactorizor.UI
{
    public static class ConsoleOutput
    {
        public static void DisplayIntroduction()
        {
            Console.WriteLine("Welcome to the Factorizor!");
            Console.WriteLine("Enter your number and we will display factors, if it is prime, and if it is perfect.");
        }
        public static void DisplayResult(int num, int[] factors, bool isPerfect, bool isPrime)
        {
            Console.WriteLine($"The factors of {num} are: {string.Join(",", factors)} ");

            if (isPerfect)
            {
                Console.WriteLine($"{num} is perfect");
            }
            else
            {
                Console.WriteLine($"{num} is not perfect");
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} is prime");
            }
            else
            {
                Console.WriteLine($"{num} is not prime");
            }

        }
        public static void DisplayClosing()
        {
            Console.WriteLine("Thank you for using our program!");
        }
    }
}
