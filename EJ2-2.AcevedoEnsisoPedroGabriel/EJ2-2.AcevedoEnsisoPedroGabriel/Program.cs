using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci A = new Fibonacci();
            bool Activo = true;
            int Numero;
            do
            {
                try
                {
                    Console.WriteLine("Introduce cuantos numeros quieres de la sucecion Fibonacci");
                    Numero = int.Parse(Console.ReadLine());
                    if (Numero < 1)
                    {
                        throw new Exception("El numero debe ser mayor o igual a 1");
                    }
                    else
                    {
                        Console.WriteLine("A continuacion se imprimen {0} numeros de la sucecion fibonacci Usando el metodo recursivo", Numero);
                        TimeSpan stop;
                        TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
                        for (int i = 1; i <= Numero; i++)
                        {
                            Console.WriteLine(A.FibonacciRecursvo(i));
                        }
                        stop = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("El tiempo de ejecucion fueron {0} milisegundos", (stop.Subtract(start).TotalMilliseconds));
                        Console.WriteLine("Presiona enter para ahora utilizar el metodo Iterativo");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("A continuacion se imprimen {0} numeros de la sucecion fibonacci Usando el metodo Iterativo", Numero);
                        TimeSpan detener;
                        TimeSpan comienzo = new TimeSpan(DateTime.Now.Ticks);
                        for (int i = 1; i <= Numero; i++)
                        {
                            Console.WriteLine(A.FibonacciIterativo(i));
                        }
                        detener = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("El tiempo de ejecucion fueron {0} milisegundos", (detener.Subtract(comienzo).TotalMilliseconds));
                        Console.WriteLine("Fin del programa presione enter para salir");
                        Activo = false;
                    }
                }
                catch (Exception General)
                {
                    Console.WriteLine(General.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Activo == true);
        }
    }
}
