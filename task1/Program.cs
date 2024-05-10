using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        delegate void GetMessage();
        static void Main(string[] args)
        {
            GetMessage del;
            if (DateTime.Now.Hour < 12)
            {
                del = Hello.GoodMorning;
            }
            else if(DateTime.Now.Hour > 12 && DateTime.Now.Hour < 16)
            {
                del = Hello.GoogAfternoon;
            }
            else { del = Hello.GoodEvening; }
            del();
            Console.ReadKey();
            
        }
    }
}
