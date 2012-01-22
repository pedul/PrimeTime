using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTime
{
    /// <summary>
    /// Known :
    ///     Except 2, all primes are odd numbers
    ///     An odd number is prime, iff there exists no prime number less then itself that can completely divide it
    ///     To find if a number is prime, it is sufficient to divide only until sqrt(number) because if there exists a number (say x)
    ///         greater than sqrt(number) that can completely divide the number, then its multiplication factor (say y = number / x) will 
    ///         have to be less than sqrt(number), which we would have already examined.
    /// </summary>
    class TrialDivisionByPrimes
    {
        List<long> _knownPrimes = new List<long>();

        public IEnumerable<long> Primes
        {
            get
            {
                _knownPrimes.Add(2);
                yield return 2;

                long nextOddNumber = 3;

                while (true)
                {
                    if (_knownPrimes.FindAll(p => p * p <= nextOddNumber)
                                    .All(p => nextOddNumber % p > 0))
                    {
                        _knownPrimes.Add(nextOddNumber);
                        yield return nextOddNumber;
                    }

                    nextOddNumber += 2;
                }
            }
        }
    }
}
