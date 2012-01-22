using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using PrimeTime;

namespace PrimeTimeLibraryTests
{
    [TestFixture]
    class PrimeTimeServiceTest
    {
        [Test]
        public void ShouldFind1stPrime()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(2, pt.FindNthPrime(1));
        }

        [Test]
        public void ShouldFind10thPrime()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(29, pt.FindNthPrime(10));        
        }

        [Test]
        public void ShouldFindSumOfAllPrimesLessThan2()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(0, pt.SumOfAllPrimesLessThan(2));
        }

        [Test]
        public void ShouldFindSumOfAllPrimesLessThan17()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(41, pt.SumOfAllPrimesLessThan(17));
        }

        [Test]
        public void ShouldFindSumOfAllPrimesLessThan10()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(17, pt.SumOfAllPrimesLessThan(10));    
        }

        [Test]
        public void ShouldFindLargestPrimeFactorOf1()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(0, pt.LargestPrimeFactorOf(1));
        }

        [Test]
        public void ShouldFindLargestPrimeFactorOf2()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(2, pt.LargestPrimeFactorOf(2));
        }

        [Test]
        public void ShouldFindLargestPrimeFactorOf29()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(29, pt.LargestPrimeFactorOf(29));
        }

        [Test]
        public void ShouldFindLargestPrimeFactorOf51()
        {
            PrimeTimeService pt = new PrimeTimeService();
            Assert.AreEqual(17, pt.LargestPrimeFactorOf(51));
        }
    }
}
