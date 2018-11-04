using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.AcevedoEnsisoPedroGabriel
{
    class Vaca
    {
        public string Nombre { get; set; }//estos atributos se usan en el ejercicio de vacas de bob
        public int Tiempo { get; set; }//usamos valores enteros para medir cuanto tarda una vaca en cruzar
        public Vaca(string name,int time)
        {
            Nombre = name;
            Tiempo = time;
        }
    }
}
