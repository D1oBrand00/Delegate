using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        delegate double Avr(double m, double n);
        static void Main(string[] args)
        {
            Avr del = AvergaeValue.Avr;
            Console.Write("Введите начало интервала: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write(del(m, n));
            Console.ReadKey();
        }
    }
}
