using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Operacion Examen = new Operacion();
                Examen.Principal();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { }
        }
    }
}
