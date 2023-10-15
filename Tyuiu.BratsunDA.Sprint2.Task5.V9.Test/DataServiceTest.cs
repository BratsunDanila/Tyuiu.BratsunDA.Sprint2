using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.BratsunDA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 10;
            int n = 10;
            Assert.AreEqual(ds.FindDateOfNextDay(m, n), "11.10");
        }
    }
}
