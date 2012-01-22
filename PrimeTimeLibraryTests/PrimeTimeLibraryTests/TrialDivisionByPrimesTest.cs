using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrimeTime;
using NUnit.Framework;

namespace PrimeTimeLibraryTests
{
    [TestFixture]
    class TrialDivisionByPrimesTest
    {
        TrialDivisionByPrimes _trialDivision;

        [TestFixtureSetUp]
        public void Setup()
        {
            _trialDivision = new TrialDivisionByPrimes();
        }

        [Test]
        public void ShouldHave2AsFirstPrime()
        {
            Assert.AreEqual(2, _trialDivision.Primes.First()); 
        }

        [Test]
        public void ShouldHave541AsHundredthPrime()
        {
            Assert.AreEqual(541, _trialDivision.Primes.Skip(99).First());
        }
    }
}
