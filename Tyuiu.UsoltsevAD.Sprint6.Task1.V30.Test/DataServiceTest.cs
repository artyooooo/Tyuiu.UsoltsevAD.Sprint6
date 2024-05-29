using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UsoltsevAD.Sprint6.Task1.V30.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -7.26;
            valueWaitArray[1] = -2.5;
            valueWaitArray[2] = 2.2;
            valueWaitArray[3] = 7.05;
            valueWaitArray[4] = 12.03;
            valueWaitArray[5] = 16;
            valueWaitArray[6] = 24.69;
            valueWaitArray[7] = 28.77;
            valueWaitArray[8] = 33.57;
            valueWaitArray[9] = 38.42;
            valueWaitArray[10] = 43.28;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
