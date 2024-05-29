using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UsoltsevAD.Sprint6.Task2.V30.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] result = new double[stopValue - startValue + 1];
            result = dataService.GetMassFunction(startValue, stopValue);
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = -15.4;
            wait[1] = -13.31;
            wait[2] = -11.36;
            wait[3] = -8;
            wait[4] = -2.62;
            wait[5] = 1.83;
            wait[6] = 4.49;
            wait[7] = 6.78;
            wait[8] = 10.58;
            wait[9] = 17.38;
            wait[10] = 23.76;
            CollectionAssert.AreEqual(result, wait);
        }
    }
}
