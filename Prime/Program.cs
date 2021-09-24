using System;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 100; i++)
            {
                if(Prime.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
