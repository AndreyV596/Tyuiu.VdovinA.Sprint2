using Tyuiu.VdovinA.Sprint2.Task4.V14.Lib;
namespace Tyuiu.VdovinA.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateFirstCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 380.427; // (2 + 1/4)^10 = (2.25)^10 ≈ 380.427
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculateSecondCondition()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 0.998; // (25 - cos²(10) + 10)/(100 - sin²(5) + 12) ≈ 0.998
            Assert.AreEqual(wait, res);
        }
    }
}