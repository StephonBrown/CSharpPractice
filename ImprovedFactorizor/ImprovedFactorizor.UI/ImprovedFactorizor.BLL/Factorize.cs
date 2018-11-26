using System;
using System.Collections.Generic;

namespace ImprovedFactorizor.BLL
{
    public static class Factorize
    {
        public static int[] Factor(int number)
        {
            List<int> nums = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    nums.Add(i);
                }
            }

            return nums.ToArray();

        }

        public static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            if (sum == number)
                return true;
            else
                return false;
        }

        public static bool IsPrime(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (i != 1 && i != number)
                    {
                        return false;
                    }
                    else if (i == number)
                    {
                        break;
                    }

                }
            }

            return true;
        }
    }
}
