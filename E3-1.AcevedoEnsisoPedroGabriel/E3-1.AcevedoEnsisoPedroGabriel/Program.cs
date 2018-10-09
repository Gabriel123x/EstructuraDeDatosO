using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        //Instrucciones de uso del programa
        //1)la manera en que funciona el programa es que al principio se te pedira cuantas clases quieres
        //2)Despues el programa te pedira la materia que se imparte en esa clase y el numero de alumnos que la cursan
        //3)Depues de introducir estos dos datos se te pedira que agregues los nombres de los alumnos de cada clase seguido de sus calificaciones respectivas
        //4)Por ultimo uno debe simplemente presionar enter para imprimir las listas de calificacion de cada clase
        static void Main(string[] args)
        {
            List<Salon> Tecnologico = new List<Salon>();//Lista de Objetos tipo Salon esto ayudo bastante a hacer el programa mas sencillo
            Salon Aula;//objeto tipo salon que se usa cuando se quiere agregar una nueva clase
            bool Activo = true;//variable que determina cuando se detiene el programa
            int TotalAlumnos;
            int TotalClases;
            string nombre;
            do//aqui comienza el ciclo del programa siempre y cuando Activo sea verdadera el programa seguira ejecutandose
            {
                try
                {
                    Console.WriteLine("Cuantas clases tiene la escuela?");
                    TotalClases = int.Parse(Console.ReadLine());
                    if (TotalClases < 0)
                        throw new Exception("El numero introducido aqui debe ser mayor a cero");//excepcion que se usa para asegurarse de que lo introducido sea mayor a cero
                    for (int i = 0; i < TotalClases; i++)//En este ciclo es donde agregamos cada clase a la lista de salones
                    {                                    //dependiendo de cuantas clases introdujo el usuario son las veces que el ciclo generara salones
                        Console.WriteLine("Cual es el nombre de la clase {0}? clases restantes {1}",(i + 1),TotalClases - (i + 1));
                        nombre = Console.ReadLine();//primero el usuario introduce el nombre de la clase
                        Console.WriteLine("Cuantos alumnos tiene?");
                        TotalAlumnos = int.Parse(Console.ReadLine());//despues el usuario introduce la catidad de alumnos que estudian en esa clase
                        if (TotalAlumnos < 0)
                            throw new Exception("El numero total de alumnos de una clase debe ser mayor a cero");//con esta escepcion nos aseguramos de que sean mas de 0 alumnos
                        Aula = new Salon(TotalAlumnos,nombre);//aqui creamos el salon con los datos introducidos
                        Tecnologico.Add(Aula);//agregamos el salon a la lista
                    }
                    Console.Clear();
                    foreach(Salon i in Tecnologico)//en este ciclo usamos los metodos PedirAlumnos y PedirCalificaciones de cada objeto Salon en la lista
                    {
                        i.PedirAlumnos();
                        i.PedirCalificaciones();
                    }
                    Console.WriteLine("Los datos de cada clase han sido agregados");
                    Console.WriteLine("A continuacion se imrimen las calificaciones de cada clase presione enter");
                    Console.ReadKey();
                    Console.Clear();
                    foreach(Salon i in Tecnologico)//en este ciclo usamos el metodo Imprimir calificaciones para imprimir las calificaciones de cada objeto salon que se encuentra en la lista
                    {
                        i.ImprimirCalificaciones();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Console.WriteLine("Fin del programa presione enter para salir");
                    Activo = false;//cambiando el valor de esta variable terminamos el programa

                }
                catch (Exception E)//excepcion general para atrapar excepciones no previstas
                {
                    Console.WriteLine(E.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Activo == true);
        }
    }
}
