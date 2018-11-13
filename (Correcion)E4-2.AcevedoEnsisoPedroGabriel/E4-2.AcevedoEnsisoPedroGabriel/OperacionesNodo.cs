using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.AcevedoEnsisoPedroGabriel
{
    class OperacionesNodo//aqui tenemos la clase operaciones nodo donde se realizan las operaciones que necesitaremos para crear nuestros 3 arbioles de ejemplo
    {
        string RutaLarga;//variable string que utilizo para ir midiendo cual es la ruta mas larga que puede tomar un arbol
        public int Niveles { get; set; }//esta variable la utilizo para contar cuantos niveles tiene un arbol
        Nodo E1, E2, E3;//creo 3 arboles apartir de la clase nodo E1,E2,E3 representan el ejercicio 1 2 y 3
        public OperacionesNodo()//constructor de esta clase
        {
            Niveles = 0;
            E1 = new Nodo();
            E2 = new Nodo();
            E3 = new Nodo();
        }
        //Creamos el arbol del ejercicio 3 aqui 
        public void CrearE3()
        {
            E3.Nombre = "K";//primero la raiz con el nombre K
            E3.Construir4Nodos();//Despues apartir de ahi instanciamos 4 nodos adicionales
            E3.Uno.Nombre = "B";//A esos 4 nodos les damos sus valores
            E3.Dos.Nombre = "A";
            E3.Tres.Nombre = "C";
            E3.Cuatro.Nombre = "D";
            E3.Cuatro.Construir2Nodos();//el nodo que tiene D tiene otros dos nodos hijos 
            E3.Cuatro.Uno.Nombre = "I";//le damos sus valores a los nodos que son hijos de D
            E3.Cuatro.Dos.Nombre = "E";
            E3.Cuatro.Uno.Construir1Nodo();//el nodo que tiene I tiene un hijo que es J
            E3.Cuatro.Uno.Uno.Nombre = "J";
            E3.Cuatro.Dos.Construir2Nodos();//el nodo que tiene E tiene dos hijos F y J
            E3.Cuatro.Dos.Uno.Nombre = "F";
            E3.Cuatro.Dos.Dos.Nombre = "G";
            E3.Cuatro.Dos.Dos.Construir1Nodo();//Por ultimo el nodo G tiene un hijo llamado H
            E3.Cuatro.Dos.Dos.Uno.Nombre = "H";
        }
        //Creamos el arbol del ejercicio 2 aqui 
        public void CrearE2()
        {
            E2.Nombre = "C";//la raiz es C
            E2.Construir4Nodos();//C tiene 4 hijos D, F, A, G
            E2.Uno.Nombre = "D";
            E2.Dos.Nombre = "F";
            E2.Tres.Nombre = "A";
            E2.Cuatro.Nombre = "G";
            E2.Tres.Construir1Nodo();//El nodo A tiene 1 hijo que es B
            E2.Tres.Uno.Nombre = "B";
            E2.Tres.Uno.Construir1Nodo();//y por ultimo el nodo B tiene un hijo mas que es E
            E2.Tres.Uno.Uno.Nombre = "E";
        }
        //Creamos el arbol del ejercicio 1 aqui 
        public void CrearE1()
        {
            E1.Nombre = "E";//la raiz es E
            E1.Construir2Nodos();//E tiene dos hijos F y A
            E1.Uno.Nombre = "F";
            E1.Dos.Nombre = "A";
            E1.Dos.Construir3Nodos();//Por ultimo A tiene tres hijos B, C y D
            E1.Dos.Uno.Nombre = "B";
            E1.Dos.Dos.Nombre = "C";
            E1.Dos.Tres.Nombre = "D";
        }
        //este es un metodo recursivo que hice para imprimir los elementos de un arbol
        //como parametros de entrada se introduce primero el objeto nodo que tiene el arbol y un string que se usa como separacion de los elementos del arbol
        public void Imprimir(Nodo Elemento, string separacion)
        {
            if (Elemento != null)//si el nodo que estamos revisando esta instanciado entonces lo va a imprimir por eso tengo los metodos de crear nodos en la clase nodo
            {
                if (separacion.Length > Niveles)//esta condicion la uso para ir checando cuantos niveles tiene el arbol
                    Niveles = separacion.Length;//simplemente uso la longitud de la separacion para encontrar eso
                Console.WriteLine(separacion + Elemento.Nombre);//escribimos la separacion + el nombre del nodo
                separacion = separacion + "-";//incrementamos la longitud de la separacion
                Imprimir(Elemento.Uno,separacion);//Volvemos mandar a llamar el metodo una ves por cada nodo
                Imprimir(Elemento.Dos,separacion);//si el nodo no existe o no fue instanciado entonces no se llamaran estos metodos
                Imprimir(Elemento.Tres,separacion);
                Imprimir(Elemento.Cuatro,separacion);
            }
        }
        //este metodo lo mando llamar para imprimir el ejercicio 1
        public void ImprimirE1()
        {
            RutaLarga = "";//el tamaño de la ruta larga se nicia desde cero
            Niveles = 0;//tambien los niveles para no confundirlos con otro ejercicio
            Console.WriteLine();//dejamos un espacio en blanco
            Imprimir(E1,"|");//mandamos llamar el metodo Imprimir
            Console.WriteLine("El nivel de este arbol es: {0} y su altura es de: {1}", Niveles - 1, Niveles);//imprimimos los niveles que tiene el arbol tambien imprimimos su altura
            CalcularRuta(E1,"");//mandamos llamar el metodo que calcula la ruta mas larga
            Console.WriteLine("La ruta mas larga en este arbol es: {0}", RutaLarga);//imprimimos esa ruta
        }
        //este metodo lo mando llamar para imprimir el ejercicio 2
        public void ImprimirE2()
        {
            RutaLarga = "";
            Niveles = 0;
            Console.WriteLine();
            Imprimir(E2,"|");
            Console.WriteLine("El nivel de este arbol es: {0} y su altura es de: {1}", Niveles - 1, Niveles);
            CalcularRuta(E2, "");
            Console.WriteLine("La ruta mas larga en este arbol es: {0}", RutaLarga);
        }
        //este metodo lo mando llamar para imprimir el ejercicio 3
        public void ImprimirE3()
        {
            RutaLarga = "";
            Niveles = 0;
            Console.WriteLine();
            Imprimir(E3,"|");
            Console.WriteLine("El nivel de este arbol es: {0} y su altura es de: {1}", Niveles - 1, Niveles);
            CalcularRuta(E3, "");
            Console.WriteLine("La ruta mas larga en este arbol es: {0}", RutaLarga);
        }
        public void CalcularRuta(Nodo Arbolito, string ruta)//el metodo calcular ruta se usa para encontrar cual es la ruta mas larga de un arbol
        {
            if (Arbolito != null)//checamos primero si el nodo esta instanciado
            {
                ruta = ruta + Arbolito.Nombre;//ok primero se le introducio a este metodo un string de tamaño cero y simplemente le agregamos el valor del nodo
                if (ruta.Length > RutaLarga.Length)//si esa longitud es mas larga que lo que tenemos en RutaLarga entonces es nuestra nueva ruta larga
                    RutaLarga = ruta;
                CalcularRuta(Arbolito.Uno, ruta);//mediante recursividad seguimos checando los demas nodos que tienen y asi se va agregando a RutaLarga el string que mas longitud tenga
                CalcularRuta(Arbolito.Dos, ruta);
                CalcularRuta(Arbolito.Tres, ruta);
                CalcularRuta(Arbolito.Cuatro, ruta);
            }
        }
    }
}
