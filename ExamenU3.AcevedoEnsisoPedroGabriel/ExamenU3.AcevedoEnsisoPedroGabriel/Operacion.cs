using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    public class Operacion
    {
        public Operacion() { }
        public void Principal()//metodo principal cada ejercicio se llama de uno por uno 
        {
            List<int> Listita = new List<int>();
            LinkedList<int> Listaligada = new LinkedList<int>();//listas pilas y colas usadas durante el ejercicio
            Stack Lista = new Stack();
            Queue Cola = new Queue();
            Ejercicio1(Lista);
            Ejercicio2();
            Ejercicio3(Listaligada,Listita);
            Ejercicio4();
        }

        public void Ejercicio1(Stack list)//ejercicio 1
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            list.Push(5);
            list.Push(3);
            list.Pop();
            list.Push(2);
            list.Push(8);
            list.Pop();
            list.Pop();
            list.Push(9);
            list.Push(1);
            list.Pop();
            list.Push(7);
            list.Push(6);
            list.Pop();
            list.Pop();
            list.Push(4);
            list.Pop();
            list.Pop();//simplemente empujamos cada accion que nos dijo que debiamos tomar e imprimimos el resultado
            Console.WriteLine("Los valores que se devuelven son:");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Ejercicio2()//aqui comienza el ejercicio 2
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            string palabra;
            string[] test = {"abstract","enum", "long", "stackalloc", "as", "event","namespace","static","base","explicit","new", "string",
"bool", "extern",   "null", "struct","break","false","object","switch","byte", "finally",  "operator","this",
"case", "Fixed",   "out", "throw", "catch",    "float",   "override",  "true",
"char",    "for",   "params",  "try", "checked",  "foreach",  "private",  "typeof",
"class",   "goto",  "protected", "uint", "const",   "if",    "public", "ulong",
"continue", "implicit",    "readonly",  "unchecked", "decimal", "in", "ref", "unsafe",
"default",  "int",  "return",   "ushort", "delegate",    "interface",   "sbyte",  "using",
"do",   "internal", "sealed", "virtual", "double",   "is",   "short", "void", "else", "lock","sizeof","while"};//agregamos manualmente cada palabra reservada de c#
            LinkedList<string> palabrareservada = new LinkedList<string>();
            LinkedList<string> identificador = new LinkedList<string>();
            LinkedList<string> literales = new LinkedList<string>();//creamos las 3 listasligadas que necesitaremos
            for(int i = 0; i < 10; i++)//en este ejercicio el usario introducira 10 textos que se acomodaran en la lista apropiada
            {
                Console.WriteLine("Introduce palabra {0}", i + 1);
                palabra = Console.ReadLine();
                int valor;
                valor = Convert.ToInt32(palabra[0]);//aqui obtenemos el valor ASCII del primer caracter de la palabra introducida 
                if (valor >= 65 && valor <= 122 || palabra[0] == '_')//si el valor ASCII esta dentro del rango de 65 a 122 entonces es una letra del abecedario
                {//tambien si comienza con _ es parte de estas
                    foreach (string item in test)
                    {
                        if (palabra == item)//checamos cada palabra del test y si coincide con lo introducido lo agregamos a la lista de palabras reservadas
                        {
                            palabrareservada.AddFirst(item);
                            goto final;
                        }
                    }
                    identificador.AddFirst(palabra);//de no ser asi se pondra como identificador ya que cumple con la mayoria de los requisitos
                final:
                    Console.Clear();
                }
                else
                {
                   literales.AddFirst(palabra);//si no cumple con ninguno de los requisitos entonces asun=miremos que es un literal
                   Console.Clear();
                }
            }
            Console.WriteLine("Identificadores introducidos");//imprimimos los elementos que se guardaron en cada listaligada
            foreach (var r in identificador)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.WriteLine("Literales introducidos");
            foreach (var r in literales)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.WriteLine("Palabras Reservadas");
            foreach (var r in palabrareservada)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio3(LinkedList<int> list, List<int> lista)//ejercicio 3
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            TimeSpan stop;//usando timespan medimos los milisegundos que tomo realizar la operacion
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            for (int cont = 0; cont < 9876;cont++)//con un for de 0 al 9875 agregamos los numeros en la lista ligada y la lista
            {
                list.AddLast(cont);
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo que añadio 9876 numeros a lista ligadas en milisegundos es");
            Console.WriteLine(stop.Subtract(start).TotalMilliseconds);//imprimimos la resta del comienzo del timespan con lo que mida el stop
            TimeSpan stop2;
            TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);
            for (int i = 0; i < 9876;i++)
            {
                lista.Add(i);
            }
            stop2 = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo que añadio 9876 numeros a lista en milisegundos es");
            Console.WriteLine(stop2.Subtract(start2).TotalMilliseconds);
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            Clase curso = new Clase();
            Stack Alumnos = new Stack();
            Stack<int> Calificaciones = new Stack<int>();//creamos una pila de calificaciones que se introduciran en nuestro metodo de la clase Clase
            Console.Write(" Numero de alumnos: ");//aqui introduce 30 para que sean los 30 alumnos
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)//con un for introducimos los nombre y calificaciones de los alumnos deseados
            {
                Console.Write(" Nombre del alumno {0}: ", i + 1);
                Alumnos.Push(Console.ReadLine());
                Console.Write(" Calificacion del alumno {0}: ", i + 1);
                Calificaciones.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(" El promedio es: {0}", curso.Promedio(Calificaciones));//usamos el metodo promedio para calcular promedio
            Console.WriteLine(" El mayor es: {0}", Calificaciones.Max());//aqui simplemente imprimimos cual es el deto de mayor valor y el de menor usando el metodo Max y Min de las pilas
            Console.WriteLine(" El menor es: {0}", Calificaciones.Min());
            Console.ReadKey();
        }
    }
}
