using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint2.Task1.V25.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            int a = 247, b = 155, c = 325, d = 857;
            CollectionAssert.AreEqual(wait, resp.GetLogicOperations(a, b, c, d));
        }
    }
}
