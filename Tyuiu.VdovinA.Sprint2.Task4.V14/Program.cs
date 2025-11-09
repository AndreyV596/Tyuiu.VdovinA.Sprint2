using Tyuiu.VdovinA.Sprint2.Task4.V14.Lib;
namespace Tyuiu.VdovinA.Sprint2.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнил: Вдовин Андрей | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Тернарный оператор                                               *");
            Console.WriteLine("*  Задание #04                                                            *");
            Console.WriteLine("*  Вариант #14                                                            *");
            Console.WriteLine("*  Выполнил: Вдовин Андрей | ПКТБ-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая вычисляет требуемое значение с             *");
            Console.WriteLine("*  использованием тернарного оператора, где пользователь вводит значение  *");
            Console.WriteLine("*  переменных x, y с клавиатуры                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}