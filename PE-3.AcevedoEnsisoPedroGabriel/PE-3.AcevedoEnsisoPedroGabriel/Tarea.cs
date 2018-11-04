using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class Tarea
    {
        Random r;
        public int ID { get; set; }//atributos de cada tarea
        public string NombreTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Tarea()
        {
            r = new Random();          
        }
        public void CrearTarea()//metodo con el que generamos el ID y creamos nuestra tarea
        {
            ID = r.Next(0, 999999);
            Console.WriteLine("Nombre de la tarea");
            NombreTarea = Console.ReadLine();
            Console.WriteLine("Descripcion de la tarea");
            DescripcionTarea = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tarea creada");
        }
    }
}
