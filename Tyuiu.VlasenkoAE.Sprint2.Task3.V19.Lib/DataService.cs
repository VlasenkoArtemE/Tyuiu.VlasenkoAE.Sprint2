using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoAE.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = (x * x) + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = (x * x + Math.Cos(x * x) + 13) / (x * x + Math.Sin(x * x) + 9);
            }
            else if ((x > -23) && (x < 2))
            {
                y = Math.Pow((1 + 1/(x * x)), x);
            }
            else if (x < -23)
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
