using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint2.Task2.V24.Lib;

namespace Tyuiu.VdovinA.Sprint2.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            
            // Тест точки вне области
            int x = 1;
            int y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            
            // Тест точки в левом столбце
            int x = 4;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            
            // Тест точки в средней полосе
            int x = 7;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            DataService ds = new DataService();
            
            // Тест точки в правом столбце
            int x = 11;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea5()
        {
            DataService ds = new DataService();
            
            // Тест точки в нижней полосе
            int x = 8;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}