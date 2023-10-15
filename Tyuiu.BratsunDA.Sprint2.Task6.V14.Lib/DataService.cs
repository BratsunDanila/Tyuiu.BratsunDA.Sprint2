using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BratsunDA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int dayOfWeek = (k + d - 2) % 7 + 1; // вычисляем день недели

            string result = string.Empty;
            switch (dayOfWeek)
            {
                case 1:
                    result = "понедельник";
                    break;
                case 2:
                    result = "вторник";
                    break;
                case 3:
                    result = "среда";
                    break;
                case 4:
                    result = "четверг";
                    break;
                case 5:
                    result = "пятница";
                    break;
                case 6:
                    result = "суббота";
                    break;
                case 7:
                    result = "воскресенье";
                    break;
                default:
                    result = "некорректный день недели";
                    break;
            }
            return result;
        }
    }
}
