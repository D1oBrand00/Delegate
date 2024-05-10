using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    /// <summary>
    /// Объявление делегата
    /// </summary>
    /// <param name="m">начальное число m</param>
    /// <param name="n">конечное число n</param>
    /// <returns></returns>
    delegate int Sum(int m, int n);
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Создание объекта делегата и присвоение ему указателя на статический метод Sum
            /// </summary>
            Sum del = Summm.Sum;
            Console.Write("Ввелите начало интервала: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Ввелите конец интервала: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(del(m, n));
            Console.ReadKey();
        }
    }
}
