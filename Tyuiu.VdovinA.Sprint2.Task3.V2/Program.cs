using Tyuiu.VdovinA.Sprint2.Task3.V2.Lib;
namespace Tyuiu.VdovinA.Sprint2.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнил: Вдовин Андрей | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Вложенные операторы  if - else                                   *");
            Console.WriteLine("*  Задание #03                                                            *");
            Console.WriteLine("*  Вариант #2                                                             *");
            Console.WriteLine("*  Выполнил: Вдовин Андрей | ПКТБ-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая вычисляет требуемое значение функции Y с   *");
            Console.WriteLine("*  использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("*  значение переменной X с клавиатуры.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("Введите значение  переменной Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();
        }
    }
}