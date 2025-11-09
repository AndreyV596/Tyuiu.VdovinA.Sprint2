using System;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VdovinA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка нахождения в верхней прямоугольной области (y = 1)
            bool inTopRectangle = (y <= 1) && (y >= 0) && (x >= -1) && (x <= 1);

            // Проверка нахождения в области под прямой y = x - 1
            bool underLine = (y <= x - 1);

            // Проверка нахождения внутри круга x² + y² = 1
            bool inCircle = (x * x + y * y <= 1);

            // Точка находится в заштрихованной области, если она:
            // 1. Находится в верхнем прямоугольнике ИЛИ
            // 2. Находится под прямой y = x - 1 И внутри круга
            return inTopRectangle || (underLine && inCircle);
        }
    }
}