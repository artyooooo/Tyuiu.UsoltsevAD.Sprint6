using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.UsoltsevAD.Sprint6.Task6.V1.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\malsu\source\repos\Tyuiu.UsoltsevAD.Sprint6\Tyuiu.UsoltsevAD.Sprint6.Task6.V1\bin\Debug\InPutFileTask6V1.txt";
            string wait = "ainUD JnYbSEpE xRh rnAUGAubeiX phe  ";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
