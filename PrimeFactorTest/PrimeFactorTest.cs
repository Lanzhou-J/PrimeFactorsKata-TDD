using System.Collections.Generic;
using PrimeFactorsKata;
using Xunit;

namespace PrimeFactorTest
{
    public class PrimeFactorTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(List(), PrimeFactors.Generate(1));
        }

        private static List<int> List()
        {
            return new List<int>();
        }
    }
}