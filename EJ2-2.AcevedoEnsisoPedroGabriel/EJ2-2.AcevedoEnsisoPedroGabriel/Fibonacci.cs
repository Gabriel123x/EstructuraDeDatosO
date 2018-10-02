using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_2.AcevedoEnsisoPedroGabriel
{
    class Fibonacci
    {
        public Fibonacci() { }
        public int FibonacciRecursvo(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else
            {
                return FibonacciRecursvo(n - 1) + FibonacciRecursvo(n - 2);
            }
        }
        public int FibonacciIterativo(int n)
        {
            int[] ArregloEntero = new int[n];
            for (int i = 0; i < n; i++)
            {
                switch (i)
                {
                    case 0:
                        ArregloEntero[i] = 1;
                        break;
                    case 1:
                        ArregloEntero[i] = 2;
                        break;
                    default:
                        ArregloEntero[i] = ArregloEntero[i - 1] + ArregloEntero[i - 2];
                        break;
                }
            }
            return ArregloEntero[n - 1];
        }
    }
}
