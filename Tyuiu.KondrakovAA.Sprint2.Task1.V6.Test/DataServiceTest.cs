using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task1.V6.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            int a = 915, b = 169, c = 174, d = 133;
            CollectionAssert.AreEqual(wait, resp.GetLogicOperations(a, b, c, d));
        }
    }
}
