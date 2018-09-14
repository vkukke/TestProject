using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnsFalseWhenValueIs1()
        {
            PrimeService p = new PrimeService();
            Assert.IsFalse(p.IsPrime(1));
        }
    }
}
