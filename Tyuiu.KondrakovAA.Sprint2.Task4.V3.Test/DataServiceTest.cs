using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(6.833, resp.Calculate(4, 6));
            Assert.AreEqual(4, resp.Calculate(3, 3));
        }
    }
}
