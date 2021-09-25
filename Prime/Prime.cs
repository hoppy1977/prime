using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

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
//                var remainder = (Math.Sqrt(candidate) % x);
                var remainder = (candidate % x);
                if (remainder == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static IList<int> GetPrimesSimple(int maxNumber)
        {
            var primes = new List<int>();

            for (var i = 0; i < maxNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static IList<int> GetPrimesParallel(int maxNumber)
        {
            var primes = new ConcurrentBag<int>();

            var candidateNumbers = Enumerable
                .Range(0, maxNumber)
                .ToList();

            Parallel.ForEach(candidateNumbers, candidate =>
            {
                if (IsPrime(candidate))
                {
                    primes.Add(candidate);
                }
            });

            var primeList = primes.ToList();
            primeList.Sort();
            return primeList;
        }

        public static void PrintPrimes(List<int> primes)
        {
            foreach (var p in primes)
            {
                Console.WriteLine(p);
            }
        }
    }
}
