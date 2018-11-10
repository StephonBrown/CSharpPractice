using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 100)
            {
                if (counter % 5 == 0 && counter % 3 == 0)
                {
                    Console.WriteLine(counter + " FizzBuzz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine(counter + " Buzz");
                }
                else if (counter % 3 == 0)
                {
                    Console.WriteLine(counter + " Fizz");
                }
                else
                {
                    Console.WriteLine(counter);
                }

                counter += 1;
            }
        }
    }
}
