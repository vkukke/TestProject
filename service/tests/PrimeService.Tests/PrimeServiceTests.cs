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
            Assert.IsFalse(p.IsPrime(1))
        }
    }
}
