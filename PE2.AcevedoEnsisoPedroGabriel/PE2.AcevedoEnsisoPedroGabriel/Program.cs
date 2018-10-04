using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Sucesion Resolver;
            int[] ArrayEnteros;
            string Seleccionador;
            int LongitudArreglo;
            bool Activo = true;
            do
            {
                try
                {
                    Console.WriteLine("Practicas evaluativas unidad 2 Estructura de datos");
                    Console.WriteLine("1) Encontrar el mayor numero de una sucecion");
                    Console.WriteLine("2) Encontrar el menor numero de una sucecion");
                    Console.WriteLine("3) Invertir la sucecion de numeros");
                    Console.WriteLine("4) Cerrar el programa");
                    Console.WriteLine("Seleccione el ejercicio introduciendo el numero indicado");
                    Seleccionador = Console.ReadLine();
                    Console.Clear();
                    switch(Seleccionador)
                    {
                        case "1":
                            Console.WriteLine("Introdusca la cantidad de numeros que estara en la sucecion");
                            LongitudArreglo = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (LongitudArreglo < 0)
                            {
                                throw new OverflowException("El numero debe ser mayor a cero");
                            }
                            else
                            {
                                ArrayEnteros = new int[LongitudArreglo];
                                for(int i = 0; i < ArrayEnteros.GetLength(0);i++)
                                {
                                    Console.WriteLine("Introduce el numero {0} del arreglo de enteros", i + 1);
                                    ArrayEnteros[i] = int.Parse(Console.ReadLine());
                                }
                                Resolver = new Sucesion(ArrayEnteros);
                                Console.WriteLine("El mayor numero del arreglo es {0}",Resolver.MayorDeSucesion(LongitudArreglo));
                            }
                            break;
                        case "2":
                            Console.WriteLine("Introdusca la cantidad de numeros que estara en la sucecion");
                            LongitudArreglo = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (LongitudArreglo < 0)
                            {
                                throw new OverflowException("El numero debe ser mayor a cero");
                            }
                            else
                            {
                                ArrayEnteros = new int[LongitudArreglo];
                                for (int i = 0; i < ArrayEnteros.GetLength(0); i++)
                                {
                                    Console.WriteLine("Introduce el numero {0} del arreglo de enteros", i + 1);
                                    ArrayEnteros[i] = int.Parse(Console.ReadLine());
                                }
                                Resolver = new Sucesion(ArrayEnteros);
                                Console.WriteLine("El menor numero del arreglo es {0}",Resolver.MenorDeSucesion(LongitudArreglo));
                            }
                            break;
                        case "3":
                            Console.WriteLine("Introdusca la cantidad de numeros que estara en la sucecion");
                            LongitudArreglo = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (LongitudArreglo < 0)
                            {
                                throw new OverflowException("El numero debe ser mayor a cero");
                            }
                            else
                            {
                                ArrayEnteros = new int[LongitudArreglo];
                                for (int i = 0; i < ArrayEnteros.GetLength(0); i++)
                                {
                                    Console.WriteLine("Introduce el numero {0} del arreglo de enteros", i + 1);
                                    ArrayEnteros[i] = int.Parse(Console.ReadLine());
                                }
                                Resolver = new Sucesion(ArrayEnteros);
                                Console.WriteLine("Acontinuacion se imprimen los numeros en orden ivertido a como se introdujeron");
                                Resolver.InvertirSucesion(LongitudArreglo);
                            }
                            break;
                        case "4":
                            Console.WriteLine("Fin del programa");
                            Activo = false;
                            break;
                        default:
                            Console.WriteLine("Caracter no aceptado solo se aceptan los nuemros enteros del 1 al 4");
                            break;
                    }

                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Activo == true) ;
        }
    }
}
