﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTime
{
    public class PrimeTimeService
    {
        public long FindNthPrime(int n)
        {
            var td = new TrialDivisionByPrimes();
            return td.Primes.Skip(n - 1).Take(1).First();
        }

        public long SumOfAllPrimesLessThan(long limit)
        {
            var soe = new SieveOfEratosthenes(limit-1);
            return soe.Primes.Sum();
        }

        public long LargestPrimeFactorOf(long number)
        {
            if (number <= 1) return 0;

            var td = new TrialDivisionByPrimes();

            long largestPrimeFound = 0;

            foreach (var prime in td.Primes)
            {
                if (prime * prime > number)
                {
                    largestPrimeFound = number;
                    break;
                }

                while (number % prime == 0)
                    number = number / prime;
            }

            return largestPrimeFound;
        }
    }
}
