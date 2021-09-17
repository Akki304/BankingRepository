using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankingRepo;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 10;
            ICalcInterest s = new CalcInterest();
            int result = s.Calculate(100, 2, 5);
            Assert.AreEqual(expected, result);
        }
    }
}
