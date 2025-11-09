using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.VdovinA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest1()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 3;
            int n = 15;

            string expected = "16.03.2023";
            string actual = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTest2()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 4;
            int n = 30;

            string expected = "01.05.2023";
            string actual = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTest3()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 12;
            int n = 31;

            string expected = "01.01.2024";
            string actual = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidTest1()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 2;
            int n = 29;

            ds.FindDateOfNextDay(g, m, n);
        }
    }
}