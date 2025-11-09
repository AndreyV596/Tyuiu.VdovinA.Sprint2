using Tyuiu.VdovinA.Sprint2.Task6.V2.Lib;
using System;

namespace Tyuiu.VdovinA.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Вдовин Андрей | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Вдовин Андрей | ПКТБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ: По данному месяцу, определите в какую пору года попадает      *");
            Console.WriteLine("* этот месяц (Зима, Лето, Весна, Осень).                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("Введите номер месяца (1-12):");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение! Месяц должен быть от 1 до 12.";
            }
            else
            {
                res = "Это время года: " + ds.FindMonthSeason(numMonth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}