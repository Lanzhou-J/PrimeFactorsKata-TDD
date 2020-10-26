using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            List<int> primes = new List<int>();
            for(int candidate = 2; number>1; candidate++)
            for (;number % candidate==0;number/=candidate)
                primes.Add(candidate);
            
            return primes;
        }
    }
}