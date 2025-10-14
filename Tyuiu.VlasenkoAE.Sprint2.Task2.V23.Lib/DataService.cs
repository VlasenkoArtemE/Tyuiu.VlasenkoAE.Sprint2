using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VlasenkoAE.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4))
            {
                res = true;
            }
            else
            {
                if ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 4))
                {
                    res = true;
                }
                else
                {
                    if ((x >= 3) && (x <= 12) && (y == 5))
                    {
                        res = true;
                    }
                    else
                    {
                        if ((x >= 7) && (x <= 13) && (y >= 6) && (y <= 8))
                        {
                            res = true;
                        }
                        else
                        {
                            if ((x >= 6) && (x <= 12) && (y >= 9) && (y <= 10))
                            {
                                res = true;
                            }
                            else
                            {
                                if ((x >= 3) && (x <= 13) && (y == 11))
                                {
                                    res = true;
                                }
                                else
                                {
                                    if ((x >= 7) && (x <= 10) && (y == 12))
                                    {
                                        res = true;
                                    }
                                    else
                                    {
                                        if ((x >= 12) && (x <= 13) && (y == 12))
                                        {
                                            res = true;
                                        }
                                        else
                                        {
                                            res = false;
                                        }

                                    }
                                } 
                            }
                        }
                    }
                }

            }
                    return res;


        }
    }
}
