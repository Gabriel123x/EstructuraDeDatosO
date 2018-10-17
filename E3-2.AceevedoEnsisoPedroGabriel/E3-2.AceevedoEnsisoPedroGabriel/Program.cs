using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2.AceevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Fila = new Queue();
            Stack Pila = new Stack();
            //Metodo EnQueue()
            //El metodo enqueue agrega un dato de cualquier tipo al final de la cola
            for (int i = 0; i < 5; i++)
            {
                Fila.Enqueue("Objeto " + i);
                //Agregamos 5 cadenas de texto a la cola usando este metodo
                //Siempre se agregaran al final de la cola
            }
            //Metodo DeQueue() 
            //Este metodo remueve y regresa el objeto que este al principio de la cola
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Fila.Dequeue());
                //Imprimimos las 5 cadenas de texto 
                //Como se podra ver el primer dato que regresa es el que se agrego primero
            }
            Console.WriteLine(Fila.Count);
            //Aqui utilizamos el metodo Count para comprobar que los elementos de la cola fueron removidos
            Console.ReadKey();
            //Metodo TrimToSize()
            Fila.TrimToSize();
            //Este metodo lo que entendi que hace es que cuando tu mandas llamar el metodo DeQueue este elmina ese elemento
            //de la cola pero al parecer esos espacios vacios siguen aun ahi ocupando memoria
            //esto ayuda a eliminar esos espacios que no estamos usando para para hacer nuestro algoritmo
            //O programa mas rapido y eficaz especialmente cuando usas colas de muchos elementos
            //Incluso cuando mandas llamar el metodo Clear() estos espacios siguen estando ahi
            //Y usar este metodo regresara la cola a su capacidad por defecto
            //Fuentes:
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.queue.trimtosize?view=netframework-4.7.2 
            //https://stackoverflow.com/questions/7817856/why-should-we-call-trimtosize-method-of-a-queue
            Console.ReadKey();
            //Metodos que encontre 
            //Metodos pila      Metodos Colas
            //Clear             Clear
            //Clone             Clone
            //Contains          Contains
            //CopyTo            CopyTo
            //Count             Count
            //Equals            Equals
            //GetEnumerator     GetEnumerator
            //GetHashCode       GetHashCode
            //GetType           GetType
            //IsSynchronized    IsSynchronized
            //OfType<>          OffType<>
            //Peek              Peek
            //Pop               DeQueue 
            //Push              EnQueue
            //SyncRoot          SyncRoot
            //ToArray           ToArray
            //ToString          ToString
            //                  TrimToSize




        }
    }
}
