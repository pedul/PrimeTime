using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrimeTime;
using NUnit.Framework;

namespace PrimeTimeLibraryTests
{
    [TestFixture]
    class SieveOfEratosthenesTest
    {
        [Test]
        public void ShouldReturnAllPrimesUpToZero()
        {
            var soe = new SieveOfEratosthenes(0);

            var expected = new List<long> { };
            Assert.AreEqual(expected, soe.Primes);
        }

        [Test]
        public void ShouldReturnAllPrimesUpToOne()
        {
            var soe = new SieveOfEratosthenes(1);

            var expected = new List<long> { };
            Assert.AreEqual(expected, soe.Primes);
        }

        [Test]
        public void ShouldReturnAllPrimesUpToTwo()
        {
            var soe = new SieveOfEratosthenes(2);

            var expected = new List<long> { 2 };
            Assert.AreEqual(expected, soe.Primes);
        }

        [Test]
        public void ShouldReturnAllPrimesUpToTen()
        {
            var soe = new SieveOfEratosthenes(10);

            var expected = new List<long> { 2, 3, 5, 7};
            Assert.AreEqual(expected, soe.Primes);
        }

        [Test]
        public void ShouldReturn541AsHundredthPrime()
        {
            var soe = new SieveOfEratosthenes(541);

            Assert.AreEqual(541, soe.Primes.Skip(99).First());
        }
    }
}
