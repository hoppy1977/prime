using Xunit;
using System.IO;
using System;
using System.Text;

namespace Prime.Test
{
    public class PrimeTest
    {
        [Fact]
        public void TestPrintPrimes_10()
        {
            using (var sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);

                // Act
                Prime.PrintPrimes(10);

                // Assert
                StringBuilder expected = new StringBuilder();

                var lines = File.ReadLines(@"..\..\..\Data\10.txt");
                foreach(var line in lines)
                {
                    expected.AppendLine(line);
                }

                Assert.Equal(expected.ToString(), sw.ToString());
            }
        }
    }
}
