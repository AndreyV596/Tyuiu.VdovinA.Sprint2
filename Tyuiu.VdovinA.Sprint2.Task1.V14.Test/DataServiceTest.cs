using Tyuiu.VdovinA.Sprint2.Task1.V14.Lib;
namespace Tyuiu.VdovinA.Sprint2.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}