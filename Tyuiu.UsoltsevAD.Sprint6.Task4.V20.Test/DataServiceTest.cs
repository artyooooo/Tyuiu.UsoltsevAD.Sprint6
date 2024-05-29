using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UsoltsevAD.Sprint6.Task4.V20.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService dataService = new DataService();
            int startStep = -5;
            int stopStep = 5;
            int len = (stopStep - startStep) + 1;
            double[] res = new double[len];
            res = dataService.GetMassFunction(startStep, stopStep);
            double[] wait = new double[len];
            wait[0] = 17.27;
            wait[1] = 14.08;
            wait[2] = 10.27;
            wait[3] = 6.65;
            wait[4] = 3.87;
            wait[5] = 2;
            wait[6] = -0.74;
            wait[7] = -3.71;
            wait[8] = -7.59;
            wait[9] = -11.55;
            wait[10] = -14.74;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
