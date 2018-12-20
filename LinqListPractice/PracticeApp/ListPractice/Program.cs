using System;
using System.Collections.Generic;
using System.Linq;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>()
            {
                10,
                11,
                12,
                13,
                14,
                15
            };

            var even = from number in nums
                       where number % 2 == 0
                       select number;

            var odd = nums.Where(number => number % 2 != 0);

            Console.WriteLine("Even numbers: {0}", string.Join(",", even));
            Console.WriteLine("Odd numbers: {0}", string.Join(",", odd));
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
