using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.UsoltsevAD.Sprint6.Task7.V15.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.UsoltsevAD.Sprint6\Tyuiu.UsoltsevAD.Sprint6.Task7.V15\bin\Debug\InPutFileTask7V15.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
