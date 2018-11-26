using System;
using ImprovedFactorizor.BLL;
using NUnit.Framework;

namespace ImprovedFactorizor.Tests
{
    [TestFixture]
    public class FactoringTests
    {
        [TestCase(6, new int[]{1,2, 3, 6})]
        [TestCase(15, new int[] { 1, 3, 5, 15 })]
        [TestCase(30, new int[] { 1,2,3,5,6,10,15,30})]
        public void FactorNumberTests(int x, int[] expected)
        {
            int[] actual = Factorize.Factor(x);
            Console.Write(actual);
            Assert.AreEqual(expected,actual);

        }

        [TestCase(6, false)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        public void IsPrimeTests(int x, bool expected)
        {
            bool actual = Factorize.IsPrime(x);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(6, true)]
        [TestCase(5, false)]
        [TestCase(28, true)]
        public void IsPerfectTests(int x, bool expected)
        {
            bool actual = Factorize.IsPerfect(x);
            Assert.AreEqual(expected, actual);

        }

    }
}
