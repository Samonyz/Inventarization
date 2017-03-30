using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;

namespace DividerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void XLessThan0()
        {
            Assert.AreEqual(Divider.Divide(-200, 20), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void XGreaterThan999()
        {
            Assert.AreEqual(Divider.Divide(1500, 20), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void XGreater0Less999()
        {
            Assert.AreNotEqual(Divider.Divide(10, 5), "Error: x must be in [0..999]");
        }
        [TestMethod]
        public void YLessThan0()
        {
            Assert.AreEqual(Divider.Divide(500, -10), "Error: y must be in (0..100]");
        }
        [TestMethod]
        public void YGreaterThan100()
        {
            Assert.AreEqual(Divider.Divide(500, 101), "Error: y must be in (0..100]");
        }
        [TestMethod]
        public void YEqual0()
        {
            Assert.AreEqual(Divider.Divide(500, 0), "Error: you cannot divide by 0 in this Universe!");
        }
        [TestMethod]
        public void YIsCorrect()
        {
            Assert.AreNotEqual(Divider.Divide(100, 10), "Error: y must be in (0..100]", "Error: you cannot divide by 0 in this Universe!");
        }
    }
}
