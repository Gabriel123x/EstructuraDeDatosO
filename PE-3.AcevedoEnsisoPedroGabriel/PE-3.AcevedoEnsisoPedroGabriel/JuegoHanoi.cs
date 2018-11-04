using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class JuegoHanoi
    {
        int elementos;
        int posicion;//valiable que usamos para indicar la posicion del cursor
        int piezaTomada;
        bool activo;
        public JuegoHanoi()
        {
            piezaTomada = 0;
            posicion = 4;
            activo = true;
        }
        public void Inicio()//metodo con el que iniciamos el juego
        {
            Console.WriteLine("Introduce de cuantos elementos tendra la torre");
            elementos = int.Parse(Console.ReadLine());//introducimos con cuantos elementos jugaremos aunque podemos jugar con 99 elementos se recomienda jugar con no mas de 7 para que no sea un juaego muy tardado
            if (elementos > 50)//el programa no acepta mas de 50 elementos ya que no cabe en la pantalla 
                throw new OverflowException("No se aceptan numeros mayores a 100");
            Hanoi hanoi = new Hanoi(elementos);//generamos nuestras torres con los elementos indicados
            hanoi.GenerarTorres();
            Console.Clear();
            while (activo == true)//comienza el juego
            {
                Console.SetCursorPosition(25, 0);//colocamos el cursor un poco a la dercha para imprimir uestros movimientos
                Console.Write("Movimientos; {0}", hanoi.TotalMovimientos);
                hanoi.ImprimirCursor(posicion, piezaTomada);//imprimimos nuestro cursor primero los parametros de entrada son la posicion en x y la pieza que tenemos tomada
                hanoi.ImprimirTorres();//imprimimos nuestras torres
                ConsoleKeyInfo Control = Console.ReadKey(true);//leemos una llave presionanda por el usuario
                switch(Control.Key)//dependiendo de que llave se presione se hara algo
                {
                    case ConsoleKey.LeftArrow://llave izquierda
                        if(posicion > 4)
                        {
                            posicion = posicion - 9;//restamos 9 a la posicion x de nuestro cursor
                        }
                        break;
                    case ConsoleKey.RightArrow://llave derecha
                        if (posicion < 22)
                        {
                            posicion = posicion + 9;//sumamos 9 a la posicion x de nuestro cursor
                        }
                        break;
                    case ConsoleKey.Enter://si presionamos enter
                        hanoi.TotalMovimientos++;//se suma un movimiento
                        if (piezaTomada == 0)//si no tenemos nada tomado entonces tomamos la pieza que este en la torre
                        {
                            piezaTomada = hanoi.QuitarPieza(posicion);
                        }
                        else//de no ser asi entonces tenemos algo tomado de ser asi se checara si es posible colocarlo en la torre
                        {
                            int numero = piezaTomada;
                            piezaTomada = hanoi.ColocarPieza(posicion, numero);//si es posible colocar la pieza en la torre la colacamos
                        }
                        activo = hanoi.ChecarVictoria();//cada que terminamos un ciclo checamos si la torre 3 esta terminada de ser asi terminamos el juego
                        break;
                    case ConsoleKey.Escape:
                        activo = false;
                        break;
                    default:
                        Console.WriteLine("Error de tecla solo se aceptan izquierda derecha y enter");
                        break;
                }     
                Console.Clear();
            }
        }
    }
}
