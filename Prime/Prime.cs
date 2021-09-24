using System;

namespace Prime
{
    public static class Prime
    {
        public static bool IsPrime(int candidate)
        {
            if(candidate == 0 || candidate == 1)
            {
                return false;
            }

            for(var x = 2; x < candidate; x++)
            {
                var remainder = (candidate % x);
                if (remainder == 0)
                {
                    return false;
                }
            }

            return true;
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
