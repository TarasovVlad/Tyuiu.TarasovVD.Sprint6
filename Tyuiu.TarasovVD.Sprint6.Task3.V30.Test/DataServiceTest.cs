using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint6.Task3.V30.Lib;

namespace Tyuiu.TarasovVD.Sprint6.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
            {-9, -4, 17, -1, 20},
            {-19, 18, -4, 2, 14},
            {-12, 16, -2, 7, 18},
            {-16, 15, 4, -12, -13},
            {-15, -4, -16, 1, -14}
        };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
            {-9, -4, 17, -1, 20},
            {-19, 18, -4, 2, 14},
            {-12, 16, -2, 7, 18},
            {-16, 15, 4, -12, -13},
            {-15, 0, 0, 1, 0}
        };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
