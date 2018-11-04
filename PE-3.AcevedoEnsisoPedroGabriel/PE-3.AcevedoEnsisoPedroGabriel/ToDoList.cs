using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class ToDoList
    {
        bool activo;
        int seleccionador;
        Tarea chores;
        List<Tarea> Pendientes = new List<Tarea>();//cremos una lista de tareas pendientes en proceso y terminadas
        List<Tarea> Proceso = new List<Tarea>();
        List<Tarea> Terminadas = new List<Tarea>();
        public ToDoList()
        {
            activo = true;
        }
        private void ImprimirTareas()//metodo con el que imprimimos todas las tareas
        {
            Console.WriteLine("Tareas pendientes");
            foreach (Tarea i in Pendientes)
            {
                Console.Write(" {0} ", i.ID);
                Console.Write(" {0} ", i.NombreTarea);
                Console.WriteLine("Descripcion: {0} ",i.DescripcionTarea);
            }
            Console.WriteLine();
            Console.WriteLine("Tareas en proceso");
            foreach (Tarea i in Proceso)
            {
                Console.Write(" {0} ", i.ID);
                Console.Write(" {0} ", i.NombreTarea);
                Console.WriteLine("Descripcion: {0} ", i.DescripcionTarea);
                Console.WriteLine("Fecha de inicio: {0} ",i.FechaInicio.ToShortDateString());
            }
            Console.WriteLine();
            Console.WriteLine("Tareas terminadas");
            foreach (Tarea i in Terminadas)
            {
                Console.Write(" {0} ", i.ID);
                Console.Write(" {0} ", i.NombreTarea);
                Console.WriteLine("Descripcion: {0} ", i.DescripcionTarea);
                Console.WriteLine("Fecha de terminacion: {0} ", i.FechaFin.ToShortDateString());
            }
        }
        private void ImprimirPendientes()//imprimimos nuestras tareas pendientes
        {
            int cont = 0;
            Console.WriteLine("Tareas pendientes");
            foreach (Tarea i in Pendientes)
            {
                cont++;
                Console.Write(" {0}){1} ",cont, i.ID);
                Console.Write(" {0} ", i.NombreTarea);
                Console.WriteLine("Descripcion: {0} ", i.DescripcionTarea);
            }
        }
        private void ImprimirProceso()//imprimimos nuestras tareas en proceso
        {
            int cont = 0;
            Console.WriteLine("Tareas en proceso");
            foreach (Tarea i in Proceso)
            {
                cont++;
                Console.Write("  {0}){1} ",cont, i.ID);
                Console.Write(" {0} ", i.NombreTarea);
                Console.WriteLine("Fecha de inicio: {0} ", i.FechaInicio.ToShortDateString());
            }
        }
        private void ImprimirMenuInicial()//imprimimos nuestro menu inicial
        {
            Console.WriteLine("To Do List");
            Console.WriteLine("  1) Ver todas las tareas");
            Console.WriteLine("  2) Crear nueva tarea");
            Console.WriteLine("  3) Iniciar tarea");
            Console.WriteLine("  4) Marcar tarea como terminada");
            Console.WriteLine("  5) Salir");
        }
        public void Inicio()//iniciamos el ejercicio
        {
            while (activo == true)
            {
                ImprimirMenuInicial();
                seleccionador = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (seleccionador)
                {
                    case 1://en el caso 1 simplemente imprimimos todas las tareas
                        ImprimirTareas();
                        break;
                    case 2:
                        chores = new Tarea();//en este caso soslo creamos una tarea pendiente nueva
                        chores.CrearTarea();
                        Pendientes.Add(chores);
                        break;
                    case 3:
                        if (Pendientes.Count == 0)//si no hay elementos en la lista imprimimos lo siguiente
                        {
                            Console.WriteLine("No hay tareas pendientes agregue una nueva tarea");
                        }
                        else
                        {
                            ImprimirPendientes();//imprimimos las tareas pendientes
                            Console.WriteLine("Cual tarea desea Comenzar?");
                            seleccionador = int.Parse(Console.ReadLine());//seleccionas cual de las tareas quieres poner como en proces
                            Pendientes[seleccionador - 1].FechaInicio = DateTime.Now;//se le da una fecha a esa tarea en este caso se le da la de la fecha de hoy
                            Proceso.Add(Pendientes[seleccionador - 1]);//se agrega esa tarea a la lista de tareas en proceso
                            Pendientes.Remove(Pendientes[seleccionador - 1]);//se quita la tarea de las tareas pendientes
                            Console.WriteLine("Tarea comenzada");
                        }
                        break;
                    case 4:
                        if (Proceso.Count == 0)//si no hay tareas en proceso.....
                        {
                            Console.WriteLine("No hay tareas pendientes agregue una nueva tarea");
                        }
                        else
                        {
                            ImprimirProceso();
                            Console.WriteLine("Cual tarea desea marcar como terminada?");
                            seleccionador = int.Parse(Console.ReadLine());//seleccionas cual de las tareas deseas poner como terminada
                            Proceso[seleccionador - 1].FechaFin = DateTime.Now;//a esa tarea se le da fecha de terminado en este caso la fecha del dia donde se indique
                            Terminadas.Add(Proceso[seleccionador - 1]);//sesa tarea se agrega a la lista de terminadas
                            Proceso.Remove(Proceso[seleccionador - 1]);//y se quita de la lista de tareas en proceso
                            Console.WriteLine("Tarea terminada");
                        }
                        break;
                    case 5:
                        Console.WriteLine("fin de programa");
                        activo = false;
                        break;
                    default:
                        Console.WriteLine("Error de seleccion solo se aceptan numeros del 1 al 5");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
