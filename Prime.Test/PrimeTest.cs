using Xunit;
using System.IO;
using System;
using System.Text;
using System.Linq;

namespace Prime.Test
{
    public class PrimeTest
    {
        [Fact]
        public void TestPrintPrimes_1000()
        {
            using (var sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);

                // Act
                var primes = Prime.GetPrimesSimple(1000)
                    .ToList();
                Prime.PrintPrimes(primes);

                // Assert
                StringBuilder expected = new StringBuilder();

                var lines = File.ReadLines(@"..\..\..\Data\1000.txt");
                foreach(var line in lines)
                {
                    expected.AppendLine(line);
                }

                Assert.Equal(expected.ToString(), sw.ToString());
            }
        }

        [Fact]
        public void TestParallelPrintPrimes_1000()
        {
            using (var sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);

                // Act
                var primes = Prime.GetPrimesParallel(1000)
                    .ToList();
                Prime.PrintPrimes(primes);

                // Assert
                StringBuilder expected = new StringBuilder();

                var lines = File.ReadLines(@"..\..\..\Data\1000.txt");
                foreach (var line in lines)
                {
                    expected.AppendLine(line);
                }

                Assert.Equal(expected.ToString(), sw.ToString());
            }
        }
    }
}
