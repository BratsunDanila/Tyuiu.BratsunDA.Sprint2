using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BratsunDA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.BratsunDA.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2| Выполнил: Брацун Д.А.| ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенный оператор switch                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил Брацун Д.А. | ПКТБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, используя оператор switch, по номеру       *");
            Console.WriteLine("* лня определяет день недели.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день недели 1 января: ");
            int d = Convert.ToInt32(Console.ReadLine());

            string res;



            res = "День недели этого дня: " + ds.FindDayName(k, d);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((k >= 1) && (k <= 365))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Неверный номер дня!!!!!!");
            }

            Console.ReadKey();
        }
    }
}
