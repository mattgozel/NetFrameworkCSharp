using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Factorizor.BLL;

namespace Factorizor.Tests
{
    [TestFixture]
    public class FactorTest
    {
        [TestCase(6, "6, 3, 2, 1, ")]
        [TestCase(4, "4, 2, 1, ")]
        [TestCase(5, "5, 1, ")]
        public void FactorFinderTest(int number, string expected)
        {
            FactorFinder factor = new FactorFinder();

            string actual = factor.FactorSender(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(28, true)]
        [TestCase(5, false)]
        [TestCase(496, true)]
        [TestCase(1, false)]
        public void PerfectTest(int number, bool expected)
        {
            PerfectChecker perfect = new PerfectChecker();

            bool actual = perfect.IsPerfectNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, true)]
        [TestCase(1, false)]
        [TestCase(15, false)]
        [TestCase(17, true)]
        public void PrimeTest(int number, bool expected)
        {
            PrimeChecker prime = new PrimeChecker();

            bool actual = prime.IsPrimeNumber(number);

            Assert.AreEqual(expected, actual);
        }
    }


}
