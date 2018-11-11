using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta es mi clase Nodo que yo hice basado en lo que entendi de los ejemplos que vi en internet
namespace E4_2.AcevedoEnsisoPedroGabriel
{
    class Nodo
    {
        public string Nombre;//el nodo acepta variables tipo string
        public Nodo Uno, Dos, Tres, Cuatro = null;//para este ejercicio el arbol puede ser de orden 1, 2, 3 o 4 osea que cada nodo puede tenr ese numero de hijos
        public void Construir1Nodo()//aqui tenemos los siguientes metodos que se usan para instanciar los nodos hijos de cada nodo
        {                           //dependiendo de cuantos nodos se necesiten 
            Uno = new Nodo();
        }
        public void Construir2Nodos()//por si el nodo tiene dos hijos usas este metodo
        {
            Uno = new Nodo();
            Dos = new Nodo();
        }
        public void Construir3Nodos()//3 hijos
        {
            Uno = new Nodo();
            Dos = new Nodo();
            Tres = new Nodo();
        }
        public void Construir4Nodos()//4 hijos
        {
            Uno = new Nodo();
            Dos = new Nodo();
            Tres = new Nodo();
            Cuatro = new Nodo();
        }
    }
}
