using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class Hanoi
    {
        public int TotalMovimientos { get; set; }//propiedad que usamos para medir los movimientos usados
        int totalDeElementos;//variable con la que indicamos con cuantos elementos se jugra
        Stack<int> torre1;//creamos las 3 torres
        Stack<int> torre2;
        Stack<int> torre3;
        public Hanoi(int elementos)//constructor
        {
            TotalMovimientos = 0;
            totalDeElementos = elementos;
            torre1 = new Stack<int>();
            torre2 = new Stack<int>();
            torre3 = new Stack<int>();
        }
        public void GenerarTorres()//creamos nuestras torres con la cantidad de elementos indicados
        {
            torre1.Push(100);
            torre2.Push(100);
            torre3.Push(100);//ponemos un 100 como base en cada torre este 100 no se imprime en el juego
            for (int i = totalDeElementos; i > 0; i--)//agregamos numeros hasta el total de elementos indicados a la primera torre
            {
                torre1.Push(i);
            }
        }
        public bool ChecarVictoria()//metodo que usamos para checar si ganamos
        {
            if (torre3.Count == totalDeElementos + 1)
            {
                Console.WriteLine("Felicidades logro acomodar todas las piezas en {0} movimientos", TotalMovimientos);//mensaje de victoria
                Console.ReadKey();
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ImprimirTorres()//metodo con el que imprimimos el contenido de las torres
        {
            int ejeY = 3;
            foreach(int i in torre1)
            {
                Console.SetCursorPosition(4,ejeY);
                if (i == 100)//nos aseguramos de no imprimir nuestra base 100
                    Console.WriteLine();
                else
                Console.Write(i);
                ejeY = ejeY + 1;
            }
            ejeY = 3;
            foreach (int i in torre2)
            {
                Console.SetCursorPosition(13, ejeY);
                if (i == 100)
                    Console.WriteLine();
                else
                    Console.Write(i);
                ejeY = ejeY + 1;
            }
            ejeY = 3;
            foreach (int i in torre3)
            {
                Console.SetCursorPosition(22, ejeY);
                if (i == 100)
                    Console.WriteLine();
                else
                    Console.Write(i);
                ejeY = ejeY + 1;
            }
        }
        public void ImprimirCursor(int position,int pieza)//imprimimos nuestro cursor seleccionador en este caso es un guin bajo
        {
            Console.SetCursorPosition(position, 0);
            Console.Write("_");
            Console.SetCursorPosition(position, 1);
            Console.WriteLine(pieza);//imprimimos la pieza seleccionada por nosotros sobre el cursor
        }
        public int QuitarPieza(int position)//metodo que usamos para quitar una pieza de la torre
        {
            switch(position)//dependiendo de donde se encuentre el cursos es de cual torre le quitaremos la pieza
            {
                case 4:
                    if (torre1.Peek() > 0 && torre1.Peek() != 100)//si lo que se encuentra en la torre es mayor a cero o no es nuestra bae tomamos la pieza
                    {
                        return torre1.Pop();
                    }
                    else
                    {
                        return 0;//de no ser asi nuestra pieza tomada segura siendo cero
                    }
                case 13:
                    if (torre2.Peek() > 0 && torre2.Peek() != 100)
                    {
                        return torre2.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                case 22:
                    if (torre3.Peek() > 0 && torre3.Peek() != 100)
                    {
                        return torre3.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    return 0;
            }
        }
        public int ColocarPieza(int position, int valor)//metodo que usamos para colocar la pieza que tenemos sostenida
        {
            if(valor == 0)
            {
                return 0;//regresa un valor a la pieza que tenemos para indicar que no tenemos pieza
            }
            else//si es que si tenemos algo como pieza
            {
                switch(position)
                {
                    case 4:
                        if(torre1.Peek() > valor)//si lo que esta en la torre es mayor a lo que tenemos lo podemos colocar ahi
                        {
                            torre1.Push(valor);//lo colocamos en la cima de la torre 
                            return 0;//regresamos un cero para indicar que no tenemos pieza
                        }
                        else
                        {
                            return valor;//si no se cumple la condicion entonces regresamos la pieza que intentamos colocar
                        }
                    case 13:
                        if (torre2.Peek() > valor)
                        {
                            torre2.Push(valor);
                            return 0;
                        }
                        else
                        {
                            return valor;
                        }
                    case 22:
                        if (torre3.Peek() > valor)
                        {
                            torre3.Push(valor);
                            return 0;
                        }
                        else
                        {
                            return valor;
                        }
                    default:
                        return 0;
                }
            }
        }
    }
}
