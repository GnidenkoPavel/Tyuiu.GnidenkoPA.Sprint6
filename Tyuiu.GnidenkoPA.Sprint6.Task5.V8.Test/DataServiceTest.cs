using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GnidenkoPA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.GnidenkoPA.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
           
            string path = Path.GetTempFileName();

          
            File.WriteAllText(path, "-5 3 -7 8 -2 10 -4");

      
            DataService ds = new DataService();

         
            double[] result = ds.LoadFromDataFile(path);

       
            double[] expected = { -5, -7, -2, -4 };

            
            CollectionAssert.AreEqual(expected, result);

           
            File.Delete(path);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InputFileTask5V8.txt";

            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            
            Assert.IsTrue(fileExists, $"Файл {path} не найден!");
        }
    }
}