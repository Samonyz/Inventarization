using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void XLessThan0()
        {
            Assert.AreEqual(Power.Calculate(-100,5), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void XMore999()
        {
            Assert.AreEqual(Power.Calculate(1000, 5), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void XMore0Less999()
        {
            Assert.AreNotEqual(Power.Calculate(340, 5), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void NMore1Less100()
        {
            Assert.AreNotEqual(Power.Calculate(5, 2), "Error: n must be in [1..100]");
        }
        [TestMethod]
        public void NLess1()
        {
            Assert.AreEqual(Power.Calculate(10, -1), "Error: n must be in [1..100]");
        }
        [TestMethod]
        public void NMore100()
        {
            Assert.AreEqual(Power.Calculate(2, 200), "Error: n must be in [1..100]");
        }
    }
}
