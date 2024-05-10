using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    static class Summm
    {
        public static int Sum(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
