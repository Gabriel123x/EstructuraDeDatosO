using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            string seleccionador;
            bool activo = true;
            do
            {
                try
                {
                    Console.WriteLine("Selecciona el ejersicio a revisar");
                    Console.WriteLine("1) Vacas de Bob");
                    Console.WriteLine("2) Torres de Hanoi");
                    Console.WriteLine("3) To do list");
                    Console.WriteLine("4) Cerrar programa");
                    seleccionador = Console.ReadLine();
                    Console.Clear();
                    switch (seleccionador)
                    {
                        case "1":
                            VacasDeBob Ejercicio1 = new VacasDeBob();                                                       
                            Ejercicio1.Inicio();
                            break;
                        case "2":
                            JuegoHanoi Ejercicio2 = new JuegoHanoi();
                            Ejercicio2.Inicio();
                            break;
                        case "3":
                            ToDoList Ejercicio3 = new ToDoList();
                            Ejercicio3.Inicio();
                            break;
                        case "4":
                            Console.WriteLine("Fin de programa");
                            activo = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (activo == true);
        }
    }
}
