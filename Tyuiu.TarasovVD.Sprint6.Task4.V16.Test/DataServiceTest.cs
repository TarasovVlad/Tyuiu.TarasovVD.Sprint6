using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint6.Task4.V16.Lib;

namespace Tyuiu.TarasovVD.Sprint6.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -36.41;
            valueWaitArray[1] = -22.07;
            valueWaitArray[2] = 5.68;
            valueWaitArray[3] = 16.72;
            valueWaitArray[4] = 8.35;
            valueWaitArray[5] = -0.5;
            valueWaitArray[6] = 9.63;
            valueWaitArray[7] = 16.29;
            valueWaitArray[8] = 5.01;
            valueWaitArray[9] = -22.4;
            valueWaitArray[10] = -36.3;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
