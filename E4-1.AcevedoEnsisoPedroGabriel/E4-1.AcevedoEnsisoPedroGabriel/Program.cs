using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.AcevedoEnsisoPedroGabriel
{
    class Program///este es un programa donde se da un ejemplo de el manejo de un arbol binario
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();//creamos un arbol binario llamado abo
            abo.Insertar(100);//insertamos los elementos este primer elemento sera nuestra raiz
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();
            //este ejemplo que utilize simplemente se le agregan elementos a un arbol binario y los imprime en posorden, inorden y preorden
            //basandome en como imprimimos los elementos durante este ejemplo dedusco que el arbol creado tiene esta forma
            //          100
            //        /     \
            //      50       150
            //    /    \
            //  25      75
        }
    }
}
