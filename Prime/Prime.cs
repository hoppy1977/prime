using System;

namespace prime
{
    public static class Prime
    {
        private static bool IsPrime(int candidate)
        {
            for(var x = 2; x < candidate; x++)
            {
                var remainder = (candidate % x);
                if (remainder == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void PrintPrimes(int maxNumber)
        {
            for (var i = 0; i < maxNumber; i++)
            {
                if (Prime.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
