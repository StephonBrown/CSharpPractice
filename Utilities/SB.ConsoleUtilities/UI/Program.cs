using System;

namespace SB.ConsoleUtilities.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            int age = userInput.GetIntFromUser("Please enter your age: ");
            int favNumber = userInput.GetIntFromUser("Please enter your favorite number");

            Console.Write($"You are {age} and your favorite number is {favNumber}!");


        }
    }
}
