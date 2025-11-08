

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovinA.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = (x - 1030) == y;
            res[1] = (x - 1030) != y;
            res[2] = (x - 1031) < y;

            res[3] = (x - 1031) > y;
            res[4] = (x - 1030) <= y;
            res[5] = (x - 1031) >= y;

            return res;
        }
    }
}