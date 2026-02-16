using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GnidenkoPA.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 3 * x + 1.2;
                if (Math.Abs(denominator) < 0.0001) 
                {
                    valueArray[index] = 0;
                }
                else
                {
                    valueArray[index] = Math.Round((2 * Math.Sin(x)) / denominator + Math.Cos(x) - 7 * x * 2, 2);
                }
                index++;
            }
            return valueArray;
        }
    }
}
