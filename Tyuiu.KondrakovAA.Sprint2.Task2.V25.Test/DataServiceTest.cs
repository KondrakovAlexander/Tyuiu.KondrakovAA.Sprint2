using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(true, resp.CheckDotInShadedArea(3,3));
        }
    }
}
