using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Aqui tenemos la clase Baraja aqui creamos nuestra baraja de cartas usando objeto tipo clase guardados en una lista y pila
    //Tambien aqui tenemos los metodos usados para generar la baraja, revolverla y prepararla para el juego
    class Baraja
    {
        Cartas card;
        Random r;
        List<Cartas> miBaraja;
        Stack<Cartas> barajaPreparada;
        public Stack<Cartas> BarajaPreparada
        {
            get { return barajaPreparada; }
            set { barajaPreparada = value; }
        }
        public Baraja()
        {
            r = new Random();
        }
        //El metodo GenerarBaraja crea una lista de cartas y agrega todas las 52 cartas de blackjack a ella
        //Lo hace haciendo uso del metodo GenerarCarta de la clase cartas 
        //Usando un simple ciclo del 0 al 12 y mandando a llamar este metodo 4 veces cada ciclo creamos las 52 cartas 
        public void GenerarBaraja()
        {
            miBaraja = new List<Cartas>(52);
            for (int i = 0; i < 13; i++)
            {
                card = new Cartas();
                card.GenerarCarta(i, "De Treboles");
                miBaraja.Add(card);
                card = new Cartas();
                card.GenerarCarta(i, "De Espadas");
                miBaraja.Add(card);
                card = new Cartas();
                card.GenerarCarta(i, "De Corazon");
                miBaraja.Add(card);
                card = new Cartas();
                card.GenerarCarta(i, "De Diamante");
                miBaraja.Add(card);
            }
        }
        //Aqui tenemos el metodo revolver con el que se barajea la lista miBaraja 
        //Hacemos un ciclo for del 0 al 51 que recorre cada carta de la lista
        //Cada carta que va recorriendo el ciclo se guarda en una variable temporal(tmp) luego se elije una de las 52 cartas al azar
        //Y la carta seleccionada a azar se guarda donde estuvo la carta que va recorriendo el indice
        //Por ultimo la variable tmp se guarda donde solia estar la variable que seleccionamos de manera aleatoria
        public void Revolver()
        {
            for (int i = 0; i < miBaraja.Count; i++)
            {
                Cartas tmp = miBaraja[i];
                int R = r.Next(i, miBaraja.Count);
                miBaraja[i] = miBaraja[R];
                miBaraja[R] = tmp;
            }
        }
        //Aqui simplemente usando un ciclo foreach guardamos cada carta en nuestra lista miBaraja en la pila barajaPreparada
        public void PrepararBaraja()
        {
            barajaPreparada = new Stack<Cartas>();
            foreach (Cartas i in miBaraja)
            {
                barajaPreparada.Push(i);
            }
        }
    }
}
