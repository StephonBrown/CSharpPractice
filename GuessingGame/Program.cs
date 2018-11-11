using System;

namespace GuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String userName = "";
            Random rand = new Random();
            int number;
            int maximum;
            String mode;
            int guessCounter = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hi! Welcome to the Guessing Game");
            while (true)
            {
                Console.WriteLine("Please tell us your name: ");
                userName = Console.ReadLine();
                if (!String.IsNullOrEmpty(userName.Trim()))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid name. Try again.");
                }
            }
            while (true)
            {
                Console.WriteLine("Which level would you like(type in the mode or the first letter of the mode)?: \n Easy(1-5) \n Normal(1-20) \n Hard(1 - 50)");
                mode = Console.ReadLine();

                if (!String.IsNullOrEmpty(mode.Trim()))
                {
                    if (mode.Trim().ToLower().Equals("easy") || mode.Trim().ToLower().Equals("e"))
                    {
                        number = rand.Next(1, 6);
                        maximum = 5;
                        Console.WriteLine("Easy mode, huh? I guess...");
                        break;
                    }
                    else if (mode.Trim().ToLower().Equals("normal") || mode.Trim().ToLower().Equals("n"))
                    {
                        number = rand.Next(1, 21);
                        maximum = 20;
                        Console.WriteLine("Normal mode. Okay, lets go!");
                        break;
                    }
                    else if (mode.Trim().ToLower().Equals("hard") || mode.Trim().ToLower().Equals("h"))
                    {
                        number = rand.Next(1, 51);
                        maximum = 50;
                        Console.WriteLine("Hard mode? Oh you came to play, play!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Please try again.");
                    }
                }
            }
            Console.WriteLine($"{userName}, you will be given a number between 1 and {maximum}.\nYou have an unlimited amount of guesses to guess this number.\nYou will be given hints if you are too high or too low.\nGood luck!");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{userName}, what is your guess? Enter Q to quit.");
                String StringGuess = Console.ReadLine();
                if (StringGuess.Trim().ToLower().Equals("q"))
                {
                    break;
                }
                else if (int.TryParse(StringGuess, out int output))
                {
                    if (output > maximum || output < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You guessed outside of the range of 1 - {maximum} \n Please try again!");
                    }
                    else if (output > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"That guess is a litte too high, {userName}! Try again.");
                        guessCounter += 1;
                    }
                    else if (output < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"That guess is a litte too low, {userName}! Try again.");
                        guessCounter += 1;

                    }
                    else if (output == number && guessCounter == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Bro/Sis/Cuz {userName}, you guessed it on your first try! Congrats!");

                    }
                    else if (output == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The number was {number}. You guessed it in {guessCounter} guesses! Congrats, {userName}!");
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid input! Try again");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("See you next time!");
        }
    }
}
