using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.AcevedoEnsisoPedroGabriel
{
    class Salon
    {
        public string NombreClase;//Variable que guarda el nombre de la materia impartida en el salon 
        public int NumeroDeDatos;
        public List<string> Alumnos;//Aqui guardamos los alumnos de la clase
        public List<int> Calificaciones;//Aqui guardamos las calificaciones de cada alumnos
        public Salon(string nombre)//Constructor
        {
            Alumnos = new List<string>();
            Calificaciones = new List<int>();
            NombreClase = nombre;
        }
        public void LeerNumeroDeAlumnos()//Metodo en el que simplemente le pedimos al usuario el numero de alumnos que cursan en este salon
        {
            Console.WriteLine("Cuantos Alumnos hay en el salon de {0}", NombreClase);
            NumeroDeDatos = int.Parse(Console.ReadLine());
            if (NumeroDeDatos < 0)
                throw new Exception("El numero introducido debe ser mayor a cero");
            Console.WriteLine("Numero Agregado");
            Console.ReadKey();
            Console.Clear();
        }
        public void PedirAlumnos()//metodo que le pide al usuario el nombre de cada alumno que cursa la clase 
        {
            for(int i = 1; i <= NumeroDeDatos;i++)
            {
                Console.WriteLine("Introduccion de Alumnos de la clase de {0}", NombreClase);
                Console.WriteLine("Introduce el alumno numero {0} alumnos restantes {1}",i,NumeroDeDatos - i);
                Alumnos.Add(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Alumnos del salon de {0} agregados",NombreClase);
            Console.ReadKey();
            Console.Clear();
        }
        public void PedirCalificaciones()//Metodo que recorre cada alumno de esta clase y le da su calificacion introducida por el usuario
        {
            for (int i = 1; i <= Alumnos.Count; i++)
            {
                Console.WriteLine("Introduccion de calificaciones de la clase de {0}", NombreClase);
                Console.WriteLine("Introdusca la calificacion del alumno {0} Alumnos restantes {1}", Alumnos[i - 1], Alumnos.Count - i);
                Calificaciones.Add(int.Parse(Console.ReadLine()));
                if (Calificaciones[i - 1] < 0 || Calificaciones[i - 1] > 100)
                    throw new Exception("La calificacion debe ser mayor o igual a cero y no sobrepasar 100");
                Console.Clear();
            }
            Console.WriteLine("Calificacioes del salon de {0} agregadas", NombreClase);
            Console.ReadKey();
            Console.Clear();
        }
        public void ImprimirCalificaciones()//metodo que imprime la calificacion de cada alumno de la clase
        {
            Console.WriteLine("Calificaciones de la materia de {0}", NombreClase);
            for (int i = 0; i < NumeroDeDatos; i++)
            {
                Console.SetCursorPosition(1,i + 1);
                Console.Write(Alumnos[i]);
                Console.SetCursorPosition(50, i + 1);
                Console.Write(Calificaciones[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
