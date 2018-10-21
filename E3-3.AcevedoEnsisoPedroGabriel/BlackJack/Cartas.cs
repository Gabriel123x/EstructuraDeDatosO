using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Esta es la clase cartas aqui se definene las caracteristicas que necesitamos de cada carta
    //Cada carta cuenta con su ID o su nombre y tambien su valor en el juego de blackJack
    class Cartas
    {
       public Cartas() { }
       public int Valor{ get; set; }         
       public string ID { get; set; }  
       //El metodo GenerarCarta lo utilizo en este programa para generar cada una de las cartas sin hacer 52 lineas de codigo
       //El metodo tiene dos parametros de entrada un entero llamado NumeroCarta y otro string llamado TipoDeCarta
       //En NumeroCarta se introduce un numero del 0 al 12 que representa cada carta en este orden:2,3,4,5,6,7,8,9,10,J,Q,K,A
       //En TipoDeCarta se introduce el tipo de carta que es ya sea treboles, espadas, diamante o corazones
       public void GenerarCarta(int NumeroCarta,string TipoDeCarta)
        {
            if(NumeroCarta < 9)
            {
                Valor = NumeroCarta + 2;
                ID = (NumeroCarta + 2) + " " + TipoDeCarta;
            }
            else
            {
                switch(NumeroCarta)
                {
                    case 9:
                        Valor = 10;
                        ID = "J " + TipoDeCarta;
                        break;
                    case 10:
                        Valor = 10;
                        ID = "Q " + TipoDeCarta;
                        break;
                    case 11:
                        Valor = 10;
                        ID = "K " + TipoDeCarta;
                        break;
                    case 12:
                        Valor = 11;
                        ID = "A " + TipoDeCarta;
                        break;
                }
            }
        }
    }
}
