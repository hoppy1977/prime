using System;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime.PrintPrimes(100);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
