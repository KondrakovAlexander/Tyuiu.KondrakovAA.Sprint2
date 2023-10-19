using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task3.V1.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(88.697, resp.Calculate(5));
            Assert.AreEqual(9.5, resp.Calculate(2));
            Assert.AreEqual(10, resp.Calculate(1));
            Assert.AreEqual(-65.995, resp.Calculate(-6));
        }
    }
}
