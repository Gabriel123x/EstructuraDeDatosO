using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2.AcevedoEnsisoPedroGabriel
{
    class Sucesion
    {
        int[] ArregloEnteros;
        int Numero;
        public Sucesion(int[] Arreglo)
        {
            ArregloEnteros = Arreglo;
        }
        public int MayorDeSucesion(int Size)
        {
            if(Size == ArregloEnteros.GetLength(0))
            {
                Numero = ArregloEnteros[Size - 1];
                return MayorDeSucesion(Size - 1);
            }
            else if(Size == 0)
            {
                return Numero;
            }
            else
            {
                if(ArregloEnteros[Size - 1] > Numero)
                {
                    Numero = ArregloEnteros[Size - 1];
                    return MayorDeSucesion(Size - 1);
                }
                else
                {
                    return MayorDeSucesion(Size - 1);
                }
            }
        }
        public int MenorDeSucesion(int Size)
        {
            if (Size == ArregloEnteros.GetLength(0))
            {
                Numero = ArregloEnteros[Size - 1];
                return MenorDeSucesion(Size - 1);
            }
            else if (Size == 0)
            {
                return Numero;
            }
            else
            {
                if(ArregloEnteros[Size - 1] < Numero)
                {
                    Numero = ArregloEnteros[Size - 1];
                    return MenorDeSucesion(Size - 1);
                }
                else
                {
                    return MenorDeSucesion(Size - 1);
                }
            }
        }
        public void InvertirSucesion(int Size)
        {
            if (Size == 1)
            {
                Console.WriteLine(ArregloEnteros[Size - 1]);
            }
            else
            {
                Console.WriteLine(ArregloEnteros[Size - 1]);
                InvertirSucesion(Size - 1);
            }
        }
    }
}
