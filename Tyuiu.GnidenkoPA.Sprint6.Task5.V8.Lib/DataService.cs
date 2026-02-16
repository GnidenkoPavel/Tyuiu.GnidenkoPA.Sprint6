using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GnidenkoPA.Sprint6.Task5.V8.Lib
{
    public class DataService : ISprint6Task5V8
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    len += numbers.Length;
                }
            }

            
            double[] allNumbers = new double[len];
            int index = 0;

          
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string num in numbers)
                    {
                        allNumbers[index] = Convert.ToDouble(num);
                        index++;
                    }
                }
            }

            
            double[] result = Array.FindAll(allNumbers, x => x < 0);

          
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Math.Round(result[i], 3);
            }

            return result;
        }
    }
}