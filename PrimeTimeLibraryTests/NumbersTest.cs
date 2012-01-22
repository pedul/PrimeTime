using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using PrimeTime;

namespace PrimeTimeLibraryTests
{
    [TestFixture]
    class NumbersTest
    {
        [Test]
        public void ShouldReturnFirst10IntegersAsLongs()
        {
            var expected = new List<long> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Assert.AreEqual(expected, Numbers.Range(1, 10).ToList<long>(), Numbers.Range(1, 10).ToList<long>().ToString());
        }

        [Test]
        public void ShouldReturnElementsBetween3and6Inclusive()
        {
            var expected = new List<long> { 3, 4, 5, 6 };

            Assert.AreEqual(expected, Numbers.Range(3, 6).ToList<long>());
        }
    }
}
