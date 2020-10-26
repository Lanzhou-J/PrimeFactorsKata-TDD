using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> primes = new List<int>();
            if (number > 1)
            {
                if (number % 2==0)
                {
                    primes.Add(2);
                    number /= 2;
                }
                if (number>1)
                {
                    primes.Add(number);
                }
            }
            return primes;
        }
    }
}