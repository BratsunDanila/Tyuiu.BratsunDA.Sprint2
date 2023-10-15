using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BratsunDA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int nextMonth;
            int nextDay;
            string[] monthNames = { "", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            string[] numberNames = { "", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < 31)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextMonth = m + 1;
                        nextDay = 1;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextMonth = m + 1;
                        nextDay = 1;
                    }
                    break;
                case 12:
                    if (n < 31)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextMonth = 1;
                        nextDay = 1;
                    }
                    break;
                case 2:
                    if (n < 28)
                    {
                        nextMonth = m;
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextMonth = m + 1;
                        nextDay = 1;
                    }
                    break;
                default:
                    return ("Неверный номер Месяца!!!!!!!!!!!!");
            }
            return ($"{numberNames[nextDay]}.{monthNames[nextMonth]}");
        }
    }
}
