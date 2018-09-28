using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1U2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return (n * Factorial(n - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el factorial de 5");
            int Total = 1;
            Console.ReadKey();
            //Primero calculamos usando ciclo for
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            for(int i = 1; i < 6;i++)
            {
                Total = Total * i;
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("El resultado de 5! es: {0} y usando ciclo for tomo: {1} milisegundos",Total, stop.Subtract(start).TotalMilliseconds);
            Console.ReadKey();
            //Ahora calculamos usando recursividad
            start = new TimeSpan(DateTime.Now.Ticks);
            Total = Factorial(5);
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("El resultado de 5! es: {0} y usando recursividad tomo: {1} milisegundos",Total, stop.Subtract(start).TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
