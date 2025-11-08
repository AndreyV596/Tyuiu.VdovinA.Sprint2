using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VdovinA.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c == d);
            res[1] = (a != b) & (c < d);
            res[2] = (a <= b) || (c > d);
            res[3] = !(a == c) && (b >= d) ^ (a < b);
            res[4] = (a < b) | (c != d) && !(b <= c);
            res[5] = (a >= b) & (c <= d);

            return res;
        }
    }
}