using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        delegate int Arith(int x, int y);
        static void Main(string[] args)
        {
            Arith del;
            del = Arithmetic.Add;
            Console.WriteLine($"Add = { del(3, 3)}");
            del = Arithmetic.Dif;
            Console.WriteLine($"Dif = { del(3, 3)}");
            del = Arithmetic.Mult;
            Console.WriteLine($"Mult = { del(3, 3)}");
            del = Arithmetic.Div;
            Console.WriteLine($"Div = { del(3, 3)}");
            Console.ReadKey();
        }
    }
}
