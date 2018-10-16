using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_1.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acevedo Ensiso Pedro Gabriel
            //Comenzamos con el metodo CopyTo()
            //primero creamos una cola de string
            //luego creamos un arreglo de size 5
            Queue<string> Cola = new Queue<string>();
            string[] ArregloString = new string[5];
            for(int i = 0; i<5; i++)
            {
                Cola.Enqueue("Hola " + i);//le agregamos rapidamente 5 "Hola" a la cola...
            }
            Cola.CopyTo(ArregloString,0);
            //Y finalmente utilizamos el metodo CopyTo() lo que hace este metodo es copiar los elementos 
            //de la cola a un arreglo unidimensional adecuado en los parametros de entrada le ponemos primero
            //el nombre del arreglo destino y el segundo parametro de tipo entero indica desde que indice del arreglo 
            //desde donde se comenzaran a copiar los elementos 
            //en este caso usamos cero para indicarle que comienze desde el primer elemento del arreglo
            foreach (string i in ArregloString)
            {
                Console.WriteLine(i);
                //por ultimo para comprobar que si se copiaron los elementos de la cola a nuestro arreglo
                //imprimimos en pantalla los elementos copiados
            }
            Console.ReadKey();
            //Metodo Equals()
            //El metodo Equals determina si un objeto especificado es igual a otro este metodo regresa un valor booleano
            //segun su resultado es el booleano que regresara
            Queue fila = new Queue(1);
            fila.Enqueue("Pedro");
            Console.WriteLine(fila.Equals(Cola));
            //primero compraremos este objeto con el que usamos en el anterior ejemplo esto debe regresar false
            Console.WriteLine(fila.Equals(fila));
            //Lo comparamos con sigomismo para ver que regresa true
            Console.ReadKey();
        }
    }
}
