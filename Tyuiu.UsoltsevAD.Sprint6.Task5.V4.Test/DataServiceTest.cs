using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.UsoltsevAD.Sprint6.Task5.V4.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.UsoltsevAD.Sprint6\Tyuiu.UsoltsevAD.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
