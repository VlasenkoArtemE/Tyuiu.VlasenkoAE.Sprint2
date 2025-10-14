using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoAE.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a + 10 >= b) & (c - 10 > d);
            res[2] = (a == b) || (c + 3 != d);
            res[3] = (a * 2 > b) && (c >= d);
            res[4] = (!(res[3]));
            res[5] = (b + 120 == a) ^ (c * 2 - 11 == d);

            return res;
        }
    }
}
