using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.AcevedoEnsisoPedroGabriel
{
    class Salon
    {
        public string NombreClase;//Variable que guarda el nombre de la materia
        public string[] Alumnos;//Aqui guardamos los alumnos de la clase
        public int[] Calificaciones;//Aqui guardamos las calificaciones de cada alumnos
        public Salon(int NumeroAlumnos,string nombre)//Constructor en el que le agregamos el nombre de la materia y la catidad de alumnos que tenemos
        {
            NombreClase = nombre;
            Alumnos = new string[NumeroAlumnos];//Iniciamos los arreglos con el volumen que se necesita de alumnos
            Calificaciones = new int[NumeroAlumnos];
        }
        public void PedirAlumnos()//metodo que recorre cada alumno de esta clase y se le agrega el nombre
        {
            for(int i = 0; i < Alumnos.Length;i++)
            {
                Console.WriteLine("Introduccion de alumnos de la clase de {0}", NombreClase);
                Console.WriteLine("Introdusca el nombre del alumno numero {0} Alumnos restantes {1}", i + 1, Alumnos.Length - (i + 1));
                Alumnos[i] = Console.ReadLine();
                Console.Clear();
            }
        }
        public void PedirCalificaciones()//Metodo que recorre cada alumno de esta clase y le da su calificacion introducida por el usuario
        {
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.WriteLine("Introduccion de calificaciones de la clase de {0}", NombreClase);
                Console.WriteLine("Introdusca la calificacion del alumno {0} Alumnos restantes {1}", Alumnos[i], Alumnos.Length - (i + 1));
                Calificaciones[i] = int.Parse(Console.ReadLine());
                if (Calificaciones[i] < 0 || Calificaciones[i] > 100)
                    throw new Exception("La calificacion debe ser mayor o igual a cero y no sobrepasar 100");
                Console.Clear();
            }
        }
        public void ImprimirCalificaciones()//metodo que imprime la calificacion de cada alumno de la clase
        {
            Console.WriteLine("Calificaciones de la materia de {0}", NombreClase);
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.SetCursorPosition(1,i + 1);
                Console.Write(Alumnos[i]);
                Console.SetCursorPosition(50, i + 1);
                Console.Write(Calificaciones[i]);
            }
        }
    }
}
