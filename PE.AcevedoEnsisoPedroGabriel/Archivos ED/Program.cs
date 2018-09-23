using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_ED
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Console.WindowWidth = 150;//Hacer ventana mas facil de visualizar
            string Seleccionador;//Seleccionamos menus
            int Tamaño;//Le damos tamaño a los arreglos
            Random Aleatorio = new Random();//Genera numeros aleatoria 
            int Grande = 0;//Guarda indices 
            int[] ArrayDeNumeros;
            string[] ArrayDeString;
            bool Parar = true;//Indica cuando detener el programa
            do
            {
                try
                {
                    Console.WriteLine("Examen unidad 1 de: Acevedo Ensiso Pedro Gabriel");
                    Console.WriteLine("1) Ejercicio 1");
                    Console.WriteLine("2) Ejercicio 2");
                    Console.WriteLine("3) Ejercicio 3");
                    Console.WriteLine("4) Ejercicio 4");
                    Console.WriteLine("5) Ejercicio 5");
                    Console.WriteLine("6) Ejercicio 6");
                    Console.WriteLine("7) Ejercicio 7");
                    Console.WriteLine("8) Ejercicio 8");
                    Console.WriteLine("9) Salir del programa");
                    Console.WriteLine("Seleccione el ejercicio que revisara");
                    Seleccionador = Console.ReadLine();
                    Console.Clear();
                    switch (Seleccionador)
                    {
                        case "1":
                            Console.WriteLine("1.- Escriba un algoritmo cuya salida sea el valor menor y mayor en la sucesión S1, . . . ,Sn");
                            Console.WriteLine("Introdusca la cantidad de numeros que desea usar");
                            Tamaño = int.Parse(Console.ReadLine());
                            ArrayDeNumeros = new int[Tamaño];
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca el numero: {0}", i + 1);
                                ArrayDeNumeros[i] = int.Parse(Console.ReadLine());
                            }
                            Array.Sort(ArrayDeNumeros);
                            Console.WriteLine("El numero menor introducido es: {0} El mayor introducido es {1}", ArrayDeNumeros[0], ArrayDeNumeros[ArrayDeNumeros.Length - 1]);
                            break;
                        case "2":
                            Console.WriteLine("2.- Escriba un algoritmo que invierta la sucesión s1, . . . , sn.");
                            Console.WriteLine("Introdusca la cantidad de string que desea usar");
                            Tamaño = int.Parse(Console.ReadLine());
                            ArrayDeString = new string[Tamaño];
                            for (int i = 0; i < ArrayDeString.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca la cadena de caracteres: {0}", i + 1);
                                ArrayDeString[i] = Console.ReadLine();
                            }
                            Console.WriteLine("A continuacion se imprimen los caracteres introducidos en orden invertido");
                            for (int i = ArrayDeString.Length; i > 0; i--)
                            {
                                Console.WriteLine(ArrayDeString[i - 1]);
                            }
                            break;
                        case "3":
                            Grande = 0;
                            Console.WriteLine("3.- Escriba un algoritmo que regrese el índice de la última ocurrencia del elemento más grande enla sucesión s1, . . . , sn.");
                            Console.WriteLine("Introdusca la cantidad de numeros que desea usar");
                            Tamaño = int.Parse(Console.ReadLine());
                            ArrayDeNumeros = new int[Tamaño];
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca el numero: {0}", i + 1);
                                ArrayDeNumeros[i] = int.Parse(Console.ReadLine());
                            }
                            for (int i = 1; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                if (ArrayDeNumeros[i] > ArrayDeNumeros[i - 1] && ArrayDeNumeros[i] >= ArrayDeNumeros[Grande])
                                {

                                    Grande = i;

                                }
                                if (ArrayDeNumeros[i] < ArrayDeNumeros[i - 1] && ArrayDeNumeros[i] >= ArrayDeNumeros[Grande])
                                {
                                    Grande = i - 1;
                                }
                            }
                            Console.WriteLine("El indice de la ultima concurrencia del elemento mas grande es: {0}", Grande + 1);
                            break;
                        case "4":
                            Console.WriteLine("4.- Escriba un algoritmo que encuentre el elemento menor entre a, b y c.");
                            ArrayDeNumeros = new int[3];
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca el numero: {0}", i + 1);
                                ArrayDeNumeros[i] = int.Parse(Console.ReadLine());
                            }
                            Array.Sort(ArrayDeNumeros);
                            Console.WriteLine("El numero menor de los 3 numeros introducidos es: {0}", ArrayDeNumeros[0]);
                            break;
                        case "5":
                            Grande = 0;
                            Console.WriteLine("5.- Escriba un algoritmo que regrese el índice de la primera ocurrencia del elemento más grandeen la sucesión s, . . . , sn.");
                            Console.WriteLine("Introdusca la cantidad de numeros que desea usar");
                            Tamaño = int.Parse(Console.ReadLine());
                            ArrayDeNumeros = new int[Tamaño];
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca el numero: {0}", i + 1);
                                ArrayDeNumeros[i] = int.Parse(Console.ReadLine());
                            }
                            for (int i = 1; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                if (ArrayDeNumeros[i] > ArrayDeNumeros[i - 1] && ArrayDeNumeros[i] > ArrayDeNumeros[Grande])
                                {

                                    Grande = i;

                                }
                                if (ArrayDeNumeros[i] < ArrayDeNumeros[i - 1] && ArrayDeNumeros[i] > ArrayDeNumeros[Grande])
                                {
                                    Grande = i - 1;
                                }
                            }
                            Console.WriteLine("El indice de la primera ocurrencia del elemento mas grande es: {0}", Grande + 1);
                            break;
                        case "6":
                            Grande = 0;
                            Console.WriteLine("6.- Escriba un algoritmo que regrese el índice del primer elemento que es mayor que supredecesor en la sucesión s1, . . . , sn. Si s está en orden no decreciente, el algoritmo regresa el valor 0.");
                            Console.WriteLine("Introdusca la cantidad de string que desea usar");
                            Tamaño = int.Parse(Console.ReadLine());
                            ArrayDeString = new string[Tamaño];
                            for (int i = 0; i < ArrayDeString.GetLength(0); i++)
                            {
                                Console.WriteLine("Introdusca la cadena de caracteres: {0}", i + 1);
                                ArrayDeString[i] = Console.ReadLine();
                            }
                            for (int i = 1; i < ArrayDeString.GetLength(0); i++)
                            {
                                if (ArrayDeString[i].Length > ArrayDeString[i - 1].Length)
                                {
                                    Grande = i;
                                }
                            }
                            if (Grande == 0)
                            {
                                Console.WriteLine("El arreglo está en orden no decreciente");
                                Console.WriteLine("El algoritmo regresa: {0}", Grande);
                            }
                            else
                            {
                                Console.WriteLine("El índice del primer elemento que es mayor que su predecesor es: {0}", Grande + 1);
                            }
                            break;
                        case "7":
                            Console.WriteLine("7.- De una lista de números random del 1 al 100 ordénelos en orden no decreciente. Mostrando los números random y los números ya ordenados.");
                            ArrayDeNumeros = new int[100];
                            Console.WriteLine("Los 100 numeros aleatorios:");
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                int r = Aleatorio.Next(1, 101);
                                ArrayDeNumeros[i] = r;
                                Console.Write(" {0}", ArrayDeNumeros[i]);
                                if(i == 49)
                                {
                                    Console.WriteLine();
                                }
                            }
                            Array.Sort(ArrayDeNumeros);
                            Console.WriteLine();
                            Console.WriteLine("Lista de numeros aleatorios ordenados de manera no decreciente");
                            for (int i = 0; i < ArrayDeNumeros.GetLength(0); i++)
                            {
                                Console.Write(" {0}", ArrayDeNumeros[i]);
                                if (i == 49)
                                {
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case "8":
                            Console.WriteLine("8.- Escriba una aplicación que Lea un entero de 5 digitos y determine si es palíndromo.");
                            bool E8 = true;
                            do
                            {
                                Console.WriteLine("Introdusca un numero de 5 digitos");
                                string numero = Console.ReadLine();
                                if (numero.Length != 5)
                                {
                                    Console.WriteLine("El numero introducido no es de 5 digitos");
                                }
                                else
                                {
                                    int Numero = 0;
                                    if(Int32.TryParse(numero,out Numero))
                                    {
                                        string NumeroInvertido = Reverse(numero);
                                        if(NumeroInvertido == numero)
                                        {
                                            Console.WriteLine("El numero es palindromo");
                                        }
                                        else
                                        {
                                            Console.WriteLine("El numero no es palindromo");
                                        }
                                        E8 = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Lo introducido no es un numero");
                                    }
                                }
                            } while (E8 == true);
                            break;
                        case "9":
                            Console.WriteLine("Finalizando el programa presione enter");
                            Parar = false;
                            break;
                        default:
                            Console.WriteLine("Caracter introducido no aceptado se aceptan los numeros del 1 al 9");
                            break;
                    }

                }
                catch(Exception Gen)
                {
                    Console.WriteLine(Gen.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Parar == true);
        }
    }
}
