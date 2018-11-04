using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class VacasDeBob
    {
        int seleccionador;
        bool activo;       
        int totaltiempo;
        Vaca Mazie = new Vaca("Mazie", 2);//creamos las 4 vacas que se nos pidio en el ejercicio
        Vaca Daisy = new Vaca("Daisy", 4);
        Vaca Crazy = new Vaca("Crazy", 10);//el numero entero a un lado del nombre es su tiempo de cruze
        Vaca Lazy = new Vaca("Lazy", 20);
        List<Vaca> Vacas = new List<Vaca>();
        public VacasDeBob()//en este metodo agregamos las 4 vacas creadas a la lista Vacas
        {
            totaltiempo = 0;
            activo = true;
            Vacas.Add(Mazie);
            Vacas.Add(Daisy);
            Vacas.Add(Crazy);
            Vacas.Add(Lazy);
        }
        private void EliminarVacaLista(Vaca animal)
        {
            Vacas.Remove(animal);
        }
        private void ImprimirVacasRestantes()//en este metodo simplemente imprimimos las vacas que se encuentran en la lista 
        {
            int conteo = 0;//usamos esta variable para imprimir tambien un numero al lado de la vaca
            foreach (Vaca animal in Vacas)
            {
                conteo++;
                Console.WriteLine("   {0} {1} tiempo de cruze: {2} minutos",conteo,animal.Nombre,animal.Tiempo);
            }
        }
        private int UnaVacaYugo(Vaca animal)//metodo que usamos cuando solo atamos una vaca al yugo
        {
            return animal.Tiempo;//simplemente regresa lo que se tarda en cruzar la vaca seleccionada
        }
        private int DosVacasYugo(Vaca animal,Vaca bestia)//metodo que usamos cuando se atan dos vacas al yugo 
        {
            if(animal.Tiempo > bestia.Tiempo)//estas condiciones se usan para saber cual es el tiempo mayor de las 2 vacas
            {
                return animal.Tiempo;//regresara el tiempo de mayor valor
            }
            else
            {
                return bestia.Tiempo;
            }
        }
        public void Inicio()//metodo que llamamos para iniciar
        {
            while (activo == true)
            {
                Console.WriteLine("Bob debe cruzar sus vacas atraves del puente en 34 minutos");
                Console.WriteLine("Tiempo transcurrido {0} minutos", totaltiempo);
                Console.WriteLine("Vacas restantes por cruzar");
                ImprimirVacasRestantes();
                if (Vacas.Count == 1)//si solo nos queda una vaca automaticamente nos elige una
                {
                    seleccionador = 1;
                }
                else//de no ser asi nos preguntara cuantas vacas queremos atar en el yugo
                {
                    Console.WriteLine("Cuantas vacas deseas cruzar con el jugo? 1 o 2?");
                    seleccionador = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                switch (seleccionador)
                {
                    case 1://si solo atamos una vaca al yugo
                        Console.WriteLine("Cual vaca deseas cruzar? introduce el numero a su izquierda");
                        ImprimirVacasRestantes();
                        seleccionador = int.Parse(Console.ReadLine());//elijes cual de las vacas ataras en el yugo
                        totaltiempo = totaltiempo + UnaVacaYugo(Vacas[seleccionador - 1]);//mandamos llamar al metodo y se lo sumamos al total del tiempo transcurrido
                        Console.WriteLine("Las vaca {0} ha cruzado el puente", Vacas[seleccionador - 1].Nombre);
                        Vacas.Remove(Vacas[seleccionador - 1]);//quitamos la vaca de la lista
                        break;
                    case 2:// si elegimos transportar 2 vacas
                        Console.WriteLine("Cual vaca deseas cruzar? introduce el numero a su izquierda");
                        ImprimirVacasRestantes();
                        seleccionador = int.Parse(Console.ReadLine());//eliges tu primera vaca
                        Console.Clear();
                        Vaca vaquita = Vacas[seleccionador - 1];//creamos una vaca temporal y guardamos la seleccion
                        Vacas.Remove(Vacas[seleccionador - 1]);//quitamos a esa vaca de la lista
                        Console.WriteLine("Selecciona la vaca que compartira el jugo");
                        ImprimirVacasRestantes();
                        seleccionador = int.Parse(Console.ReadLine());//seleccionamos segunda vaca
                        totaltiempo = totaltiempo + DosVacasYugo(vaquita, Vacas[seleccionador - 1]);//sumamos el tiempo al total usando el metodo que nos pide 2 vacas
                        Console.WriteLine("Las vacas {0} y {1} han cruzado el puente", Vacas[seleccionador - 1].Nombre, vaquita.Nombre);
                        Vacas.Remove(Vacas[seleccionador - 1]);//quitamos la segunda vaca de la lista
                        break;
                    default:
                        Console.WriteLine("Indice introducido incorrecto");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                if (Vacas.Count == 0)//cuando se nos acaben las vacas
                {
                    Console.WriteLine("Ya has terminado de cruzar las 4 vacas tu tiempo fue de {0} minutos", totaltiempo);
                    if (totaltiempo == 34)//si lograste cruzarlas en excactamente 34 minutos
                    {
                        Console.WriteLine("Felicidades lograste cruzar en 34 minutos");
                    }
                    else//de no ser asi
                    {
                        Console.WriteLine("No curzaste en excactamente 34 intenta de nuevo");
                    }
                    activo = false;
                }
            }
        }
    }
}
