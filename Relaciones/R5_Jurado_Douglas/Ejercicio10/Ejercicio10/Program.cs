using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static int[,] PiramidePascal(int tamano)
        {
            int[,] piramide = new int[tamano, tamano];
            int numero = 1;

            for (int i = 0; i < piramide.GetLength(0); i++)
            {
                for (int j = 0; j < piramide.GetLength(1); j++)
                {
                    piramide[i, j] = numero;
                }
            }

            return piramide;
        }
    }
}
