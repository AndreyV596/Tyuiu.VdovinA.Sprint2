using Tyuiu.VdovinA.Sprint2.Task5.V11.Lib;
using System;

namespace Tyuiu.VdovinA.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Вдовин Андрей | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор Switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Вдовин Андрей | ПКТБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ: Дата некоторого дня характеризуется тремя натуральными         *");
            Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число).             *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                   *");
            Console.WriteLine("* Заданный год не является високосным.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int g = 2023;
            int m = 3;
            int n = 15;

            Console.WriteLine($"Год: {g}");
            Console.WriteLine($"Месяц: {m}");
            Console.WriteLine($"День: {n}");

            string result = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Дата следующего дня: {result}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}