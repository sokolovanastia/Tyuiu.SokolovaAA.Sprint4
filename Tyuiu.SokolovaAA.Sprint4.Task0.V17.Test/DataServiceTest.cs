using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.SokolovaAA.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void GetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };//
            int res = ds.GetSumEvenArrEl(numArray);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}
