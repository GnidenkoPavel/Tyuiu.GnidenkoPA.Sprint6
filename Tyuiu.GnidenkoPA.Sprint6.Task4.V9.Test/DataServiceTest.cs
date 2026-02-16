using Tyuiu.GnidenkoPA.Sprint6.Task4.V9.Lib;
namespace Tyuiu.GnidenkoPA.Sprint6.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] wait = new double[]
            {
                -27.22, -22.25,-16.66,-11.04,-6.13, -3.00, 4.84 , 8.86, 14.43, 20.18, 25.24
            };
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));

        }
    }
}
