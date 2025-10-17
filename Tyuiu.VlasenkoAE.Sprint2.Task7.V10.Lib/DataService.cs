using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoAE.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            DataService ds = new DataService();

            bool res;
            if (((x * x) - y - 2 <= 0) && ((x - y >= 0) || (x + y <= 0)))
            {
                res = true;
            }     
            else
            {
                res = false;
            }
            return res;
        }
    }
}
