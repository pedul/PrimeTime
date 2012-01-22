using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTime
{
    class SieveOfEratosthenes
    {
        long _limit;

        public SieveOfEratosthenes(long limit)
        {
            _limit = limit;
        }

        public IEnumerable<long> Primes
        {
            get
            {
                List<long> _possiblePrimes = Numbers.Range(2, _limit).ToList();

                long lastPrimeFound = 2;

                while (lastPrimeFound <= Math.Sqrt(_limit))
                {
                    _possiblePrimes.RemoveAll(no => no != lastPrimeFound && no % lastPrimeFound == 0);

                    lastPrimeFound = _possiblePrimes.First(no => no > lastPrimeFound);
                }

                foreach (var p in _possiblePrimes)
                    yield return p;
            }
        }
    }
}
