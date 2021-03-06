using System.Collections.Generic;
using PrimeFactorsKata;
using Xunit;
using static PrimeFactorsKata.PrimeFactors;

namespace PrimeFactorTest
{
    public class PrimeFactorTest
    {
        private static List<int> List(params int[] ints)
        {
           var list =  new List<int>();
           foreach (var item in ints)
           {
               list.Add(item);
           }

           return list;
        }
        
        [Fact]
        public void Test1()
        {
            Assert.Equal(List(), Generate(1));
        }
        
        [Fact]
        public void Test2()
        {
            Assert.Equal(List(2), Generate(2));
        }
        
        [Fact]
        public void Test3()
        {
            Assert.Equal(List(3), Generate(3));
        }
        
        [Fact]
        public void Test4()
        {
            Assert.Equal(List(2,2), Generate(4));
        }
        
        [Fact]
        public void Test5()
        {
            Assert.Equal(List(2,3), Generate(6));
        }
        
        [Fact]
        public void Test6()
        {
            Assert.Equal(List(2,2,2), Generate(8));
        }
        
        [Fact]
        public void Test7()
        {
            Assert.Equal(List(3,3), Generate(9));
        }
        
    }
}