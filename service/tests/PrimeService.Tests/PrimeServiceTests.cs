using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
