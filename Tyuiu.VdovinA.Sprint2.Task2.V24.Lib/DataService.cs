using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovinA.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            // Описание заштрихованной области по координатам
            if (
                // Левый вертикальный столбец (x=3-5, y=3-11)
                ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 11)) ||

                // Средняя горизонтальная полоса (x=6-9, y=6-8)
                ((x >= 6) && (x <= 9) && (y >= 6) && (y <= 8)) ||

                // Правый вертикальный столбец (x=10-12, y=3-7)
                ((x >= 10) && (x <= 12) && (y >= 3) && (y <= 7)) ||

                // Нижняя горизонтальная полоса (x=6-12, y=9-11)
                ((x >= 6) && (x <= 12) && (y >= 9) && (y <= 11)) ||

                // Верхняя горизонтальная полоса (x=6-12, y=3-5)
                ((x >= 6) && (x <= 12) && (y >= 3) && (y <= 5))
            )
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