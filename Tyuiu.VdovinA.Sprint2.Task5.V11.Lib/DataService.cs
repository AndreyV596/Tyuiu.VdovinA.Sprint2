using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovinA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g <= 0 || m <= 0 || m > 12 || n <= 0)
                throw new ArgumentException("Некорректные входные данные");

            if (n > GetDaysInMonth(g, m))
                throw new ArgumentException("Некорректный день для данного месяца");

            int nextDay, nextMonth, nextYear;

            // Если день не последний в месяце
            if (n < GetDaysInMonth(g, m))
            {
                nextDay = n + 1;
                nextMonth = m;
                nextYear = g;
            }
            else
            {
                // Последний день месяца - переход на следующий месяц
                nextDay = 1;
                if (m < 12)
                {
                    nextMonth = m + 1;
                    nextYear = g;
                }
                else
                {
                    // Декабрь - переход на следующий год
                    nextMonth = 1;
                    nextYear = g + 1;
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }

        private int GetDaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28; // Год не високосный по условию
                default:
                    throw new ArgumentException("Некорректный номер месяца");
            }
        }
    }
}