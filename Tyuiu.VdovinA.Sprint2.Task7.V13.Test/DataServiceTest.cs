using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.VdovinA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки в верхнем прямоугольнике
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 1));
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0));

            // Точки под прямой и внутри круга
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, -0.7));
            Assert.IsTrue(ds.CheckDotInShadedArea(0.3, -0.5));

            // Точки вне области
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));
            Assert.IsFalse(ds.CheckDotInShadedArea(-2, -2));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.8, 0.8)); // над прямой внутри круга
        }
    }
}