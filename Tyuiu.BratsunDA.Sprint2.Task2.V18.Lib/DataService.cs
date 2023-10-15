using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BratsunDA.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y == 6 || y == 7 && x >= 2 && x <= 8) || (y >= 3 && y <= 4 && x >= 3 && x <= 5) || (y == 5 && x >= 3 && x <= 8) || (y == 11 && x >= 3 && x <= 7) || (x == 6 || x == 7 && y >= 8 && y <= 10) || (y == 8 || y == 9 && x >= 8 && x <= 12) || (x == 11 || x == 12 && (y == 10 || y == 11)) || (x == 12 && y >= 3 && y <= 7) || (x == 13 && y >= 6 && y <= 8) || (x == 7 && y == 12))
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
