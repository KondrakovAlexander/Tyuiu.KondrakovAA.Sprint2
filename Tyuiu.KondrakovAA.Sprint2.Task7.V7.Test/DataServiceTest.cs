using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(true, resp.CheckDotInShadedArea(1, 0.4));
            Assert.AreEqual(true, resp.CheckDotInShadedArea(-0.8, 1));
            Assert.AreEqual(false, resp.CheckDotInShadedArea(0.2, -0.4));
        }
    }
}
