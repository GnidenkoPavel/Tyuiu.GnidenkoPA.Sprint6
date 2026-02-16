using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GnidenkoPA.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = Math.Round(((5 * i + 2.5) / (Math.Sin(i) + 2)) + 2 * i + 2, 2);



                if (Math.Sin(i) == -2)
                {
                    res[i] = 0;
                }
                res[count] = y;

                count++;
            }
            return res;
        }
    }
}
