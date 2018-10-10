using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.C.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejersisio de Acevedo Ensiso pedro Gabriel
            //Utilizacion de Contains, GetType, ToString, ToArray, GetEnumerator
            Stack<string> Pila = new Stack<string>();
            Pila.Push("Hola");
            Pila.Push("Soy");
            Pila.Push("Pedro");//creamos una pila de ejmplo con estos 3 elementos

            Console.WriteLine("Metodo Contains");
            //el metodo contains regresa verdadero o falso si lo que se busca existe o no dentro de la pila se puede usar cuando
            //queremos comprobar si algo existe dentro de una pila
            Console.WriteLine(Pila.Contains("Pedro"));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Metodo GetType");
            //con lo que te regresa aqui puedes conocer el tipo de dato que es para saber que hacer con el 
            //puedes usarlo en condiciones dependiendo del ejersicio aqui te da el tipo de dato y libreria
            //del tipo de dato que es
            Console.WriteLine(Pila.Peek().GetType());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Metodo ToString");
            Console.WriteLine(Pila.Peek().ToString());
            //El metodo ToString regresa una representacion en texto de lo que esta guardado 
            //en la pila su implementacion es muy similar al gettype 
            //si lo que esta en la pila es una string o algo asi entonces 
            //simplemente regresa lo que esta ahi osea en este caso regresara pedro
            Console.ReadKey();
            Console.Clear();

            string[] Arreglo = new string[3];
            Arreglo = Pila.ToArray();
            Stack Pila2 = new Stack(Pila.ToArray());
            //El metodo ToArray copia los elementos de la pila a una nueva pila o a otro arreglo adecuado
            Console.WriteLine("Metodo ToArray");
            Console.WriteLine("Elementos de la pila");
            foreach (var i in Pila)
            {
                Console.WriteLine(i);
                //imprimimos la pila original para comprobar la manera en que se guardaron los datos
            }
            
            Console.WriteLine("\nLa copia de la pila guardada en una pila nuevausando ToArray");
            foreach (var i in Pila2)
            {
                Console.WriteLine(i);
                //imprimimos los elementos que guardamos en pila 2 para comprobar si estan ahi
                //nota la manera en que se guardan los elementos en la pila nueva es en reversa
            }
            Console.WriteLine("\nLa copia de la pila guardada en un arreglo usando ToArray");
            foreach (var i in Arreglo)
            {
                Console.WriteLine(i);
                //imprimimos los elementos que guardamos en el arreglo para comprobar si estan ahi
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Metodo GetEnumerator");
            //Este metodo regresa un enumerador de la pila en cuestion
            //Disculpe maestro pero este es el unico metodo que no entendi vi varios ejemplos en linea
            //Y estos imprimen cosas que no conosco su significado 
            //Segun varias fuentes es un IEnumerator de la pila
            Console.WriteLine(Pila.GetEnumerator());
            //aqui imprime algo similar a GetType pero con informacion extra que no comprendo
            Console.ReadKey();
        }
    }
}
