using System;

namespace Factorizor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String userInput;
            int output;
            while (true)
            {
                Console.WriteLine("What number would you like to factor? ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out output) && output > 0)
                {
                    Factor(output);
                    IsPerfect(output);
                    IsPrime(output);
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

        }

        public static void Factor(int number)
        {
            String num = $"The factors of {number} are :";
            for (int i = 1; i <=number; i++)
            {
                if (number % i == 0)
                {
                    num = String.Concat(num, " " + i);
                }
            }
            Console.WriteLine(num);

        }
        public static void IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }

        public static void IsPrime(int number)
        {

            for (int i = 1; i <=number; i++)
            {
                if (number % i == 0)
                {
                    if (i != 1 && i != number)
                    {
                        Console.WriteLine($"{number} is not a prime number.");
                        break;
                    }else if(i == number)
                    {
                        Console.WriteLine($"{number} is a prime number.");
                        break;
                    }

                }
            }

        }

    }
}
