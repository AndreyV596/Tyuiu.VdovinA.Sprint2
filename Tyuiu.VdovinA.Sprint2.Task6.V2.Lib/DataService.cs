using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovinA.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            string result = value switch
            {
                12 or 1 or 2 => "зима",
                3 or 4 or 5 => "весна",
                6 or 7 or 8 => "лето",
                9 or 10 or 11 => "осень",
                _ => throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}")
            };
            return result;
        }
    }
}