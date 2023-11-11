using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint4.Task5.V3.Lib;
namespace Tyuiu.SokolovaAA.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { {-1, 2, -3, 4, 2},
                                            {-3, 2, 3, -1, 4},
                                            {4, 1, 2, -2, -4},
                                            {-2, 4, 3, -3, -2},
                                            {-5, -3, 4, 2, -1} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {   {0, 2, 0, 4, 2},
                                            {0, 2, 3, 0, 4},
                                            {4, 1, 2, 0, 0},
                                            {0, 4, 3, 0, 0},
                                            {0, 0, 4, 2, 0} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
