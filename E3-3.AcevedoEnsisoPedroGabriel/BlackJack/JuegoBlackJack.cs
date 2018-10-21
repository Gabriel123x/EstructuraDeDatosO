using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Aqui tenemos la clase JuegoBlackJack este clase es donde crearemos el metod que sera nuestro juego de blackjack
    //para asi mandarlo a llamar en el main y mantener nuestro main limpio
    class JuegoBlackJack
    {
        //Para comenzar creamos variables enteras que llevaran un conteo de cuantas victorias y perdidas llevamos
        //Tambien se creo una lista de cartas llamada MyHand donde guardaremos cada carta que saquemos de la baraja
        int victorias;
        int perdidas;
        List<Cartas> MyHand = new List<Cartas>();
        public JuegoBlackJack() { }
        //Aqui tenemos el metodo ComenzarJuego() mandando a llamar este metodo comenzamos el juego
        public void ComenzarJuego()
        {
            int TieneA = 0;//Utilizamos esta variable entera tieneA para detectar cuantos ases que valen 11 tenemos en nuestra mano
            int total = 0;//Variable que utilizamos para sumar los puntos de cada carta que tomemos
            Baraja BlackJack = new Baraja();//Objeto tipo BlackJack con el que generamos la baraja
            BlackJack.GenerarBaraja();//Creamos baraja de 52 cartas
            BlackJack.Revolver();//La revolvemos
            BlackJack.PrepararBaraja();//Y la preparamos para su uso mandandola a la pila
            do
            {
                Console.WriteLine("Juego de blackjack victorias: {0} derrotas: {1} cartas restantes {2}", victorias, perdidas,BlackJack.BarajaPreparada.Count);
                Console.WriteLine("Para comenzar presione enter");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    MyHand.Add(BlackJack.BarajaPreparada.Pop());//Aqui sacamos una carta de la pila BarajaPreparada y la agregamos a nuestra mano
                    //Aqui utilizamos una serie de condiciones para sumar los valores de cada carta que vamos jalando
                    if (MyHand[MyHand.Count - 1].Valor > 10)//Con esta primera condicion basicamente checamos si lo que jale es un As ya que los Ases valen 11
                    {
                        if (total <= 10)//Si el total de puntos es menor o igual a 10 le sumamos 11
                        {
                            total = total + 11;
                            TieneA = TieneA + 1;//despues de sumar un As como 11 indicamos que tenemos un As que vale eso 
                        }
                        else//si nuestra moano tiene mas de 10 puntos entonces el As valdra 1
                        {
                            total = total + 1;
                        }
                    }
                    else//si jalamos cualquier cosa que no sea un As simplemente lo sumamos al total
                    {
                        total = total + MyHand[MyHand.Count - 1].Valor;
                        if (total > 21 && TieneA > 0)//pero si al sumarlo nos pasamos del valor y tenemos un As que vale 11
                        {
                            total = total - 10;//Hacemos que ese As valga uno restandole 10 al total
                            TieneA = TieneA - 1;//Y finalmente quitamos el hecho de que tenemos un As
                        }
                    }
                    Console.WriteLine("Total de cartas = {0} Total de puntos = {1}\n", BlackJack.BarajaPreparada.Count, total);
                    Console.WriteLine("Tus cartas actuales son:\n");
                    foreach (var item in MyHand)
                    {
                        Console.WriteLine("   " + item.ID);//Aqui le imprimimos al jugador las cartas que tiene actualmente en su mano
                    }
                    Console.WriteLine("\nPresione enter para tomar otra carta");
                    Console.ReadKey();
                    Console.Clear();
                    //El Juego termina cuando se acaben las cartas de la baraja(pila) o el nuemro de cartas jaladas sean 5 o cuando tus puntos sean mayores a 20 
                } while (MyHand.Count < 5 && total < 21 && BlackJack.BarajaPreparada.Count > 0);
                if (total == 21)//Uilizamos estas condiciones para checar si el total de puntos es igual a 21 si lo es marcamos la victoria
                {
                    Console.WriteLine("Victoria! Ganaste el juego");
                    victorias = victorias + 1;
                }
                else
                {
                    Console.WriteLine("Perdiste.... intenta de nuevo");
                    perdidas = perdidas + 1;
                }
                total = 0;//Reiniciamos los puntos a cero para el siguiente juego
                TieneA = 0;
                MyHand = new List<Cartas>();//Tambien nos desacemos de nuestra mano vieja y creamos una nueva
                Console.ReadKey();
                Console.Clear();
            } while (BlackJack.BarajaPreparada.Count > 0);//Los juegos continuara hasta que se acaben las barajas
            Console.WriteLine("Fin del juego se acabaron las cartas... tu puntuacion fue de:\n {0} victorias y {1} derrotas",victorias,perdidas);
            Console.ReadKey();
        }
    }
}
