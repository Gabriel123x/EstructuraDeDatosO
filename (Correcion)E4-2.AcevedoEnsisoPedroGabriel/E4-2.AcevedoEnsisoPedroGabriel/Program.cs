using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui en el main primero instanciamos la clase OperacionesNodo 
            OperacionesNodo Ejercicio1 = new OperacionesNodo();
            Ejercicio1.CrearE1();//Creamos el arbol
            Ejercicio1.ImprimirE1();//imprimimos resultados
            Ejercicio1.CrearE2();//y lo mismo con los demas arboles
            Ejercicio1.ImprimirE2();
            Ejercicio1.CrearE3();
            Ejercicio1.ImprimirE3();
            Console.ReadKey();
        }
    }
}
