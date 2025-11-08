using Tyuiu.VdovinA.Sprint2.Task0.V27.Lib;

namespace Tyuiu.VdovinA.Sprint2.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}