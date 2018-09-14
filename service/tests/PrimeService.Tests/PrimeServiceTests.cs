using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrimeService.Tests
{
    [TestClass]
    public class PrimeServiceTests
    {
        [TestMethod]
        public void ReturnsFalseWhenValueIs1()
        {
            PrimeService p = new PrimeService();
            Assert.IsFalse(p.IsPrime(1));
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void ReturnsFalseWhenValueIs2(int value)
        {
            PrimeService p = new PrimeService();
            Assert.IsFalse(p.IsPrime(value));
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
       public void ReturnsNotImplementedWhenValueIsGreaterThan2()
        {
            PrimeService p = new PrimeService();
            p.IsPrime(3);
        }
    }
}
