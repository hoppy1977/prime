using System;
using System.Linq;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var primes = Prime.GetPrimesSimple(10).ToList();
            var primes = Prime.GetPrimesParallel(100).ToList();
            Prime.PrintPrimes(primes);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
