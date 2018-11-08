using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.AcevedoEnsisoPedroGabriel
{
    class ArbolBinarioOrdenado//encontre este ejemplo de un arbol binario esta clase es la que se usa para implementar un arbol binario
    {
        class Nodo//se implementa una clase nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;//se instancia ese nodo con un nombre raiz

        public ArbolBinarioOrdenado()//constructor de la clase arbol binario ordenado 
        {
            raiz = null;
        }

        public void Insertar(int info)//llamando este metodo insertas nuevos elementos al arbol en este caso se insertan elementos enteros
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)//entiendo que si la raiz no tiene ningun elemento entonces se guarda en el
                raiz = nuevo;
            else//de no ser asi se guardara en el que siga
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirPre(Nodo reco)//por lo que entiendo este es el metodo para imprimir en preorden al parecer este es un metodo recursivo
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);//aqui se vuelve a llamar asi mismo este metodo
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()//este metodo manda a llamar el metodo recursivo ImprimirPre
        {
            ImprimirPre(raiz);//comenzando desde la raiz (el elemento de mas arriba)
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco)//metodo recursivo con el que imprimimos los elementos en orden in-orden
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()//este es el metodo inicial que mandara a llamar la recursividad
        {
            ImprimirEntre(raiz);//en este caso el primer elemento que se va a imprimir sera el elemento que este en la parte inferior izquierda
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco)//metodo recursivo que se usa para imprimir en pos-orden
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost()//metodo que inicialmete mandara a llamar el metodo recursivo
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
