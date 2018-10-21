using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Programa hecho por Acevedo Ensiso Pedro Gabriel
    class Program
    {
        static void Main(string[] args)
        {//Aqui tenemos el main simplemente creamos un objeto JuegoBlackJack y mandamos llamar el metodo que comienza el juego
            JuegoBlackJack Juego = new JuegoBlackJack();
            Juego.ComenzarJuego();
        }
    }
}
