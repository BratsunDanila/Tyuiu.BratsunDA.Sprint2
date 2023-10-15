using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.BratsunDA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 7;
            int d = 1;
            Assert.AreEqual("воскресенье", ds.FindDayName(k, d));
        }
    }
}
