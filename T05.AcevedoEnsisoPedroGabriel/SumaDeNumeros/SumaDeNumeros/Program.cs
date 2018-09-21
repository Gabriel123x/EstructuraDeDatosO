using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            int Numero = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                Numero = Numero + i;
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine(stop.Subtract(start).TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
