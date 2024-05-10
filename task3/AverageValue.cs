using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class AverageValue
    {
        public static double Avr(double m, double n)
        {
            double sum = 0;
            double dif = n - m + 1;
            for (double i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum / dif; ;
        }
    }
}
