using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> primes = new List<int>();
            int candidate = 2;
            while (number > 1)
            {
                while (number % candidate==0)
                {
                    primes.Add(candidate);
                    number /= candidate;
                }
                candidate++;
            }
            if (number>1)
            {
                primes.Add(number);
            }
            return primes;
        }
    }
}