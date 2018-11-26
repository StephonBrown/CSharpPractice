using System;
namespace SB.ConsoleUtilities
{
    public class UserInput
    {
        public int GetIntFromUser(string message)
        {
            string userInput;

            while (true)
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result))
                {
                    return result;
                }
                Console.WriteLine("This is not a valid input!");
                Console.ReadKey();
            }
        }
    }
}
