using Tyuiu.VdovinA.Sprint2.Task3.V2.Lib;
namespace Tyuiu.VdovinA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = -54.716;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -0.577;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = -109.999;
            Assert.AreEqual(wait, res);
        }
    }
}