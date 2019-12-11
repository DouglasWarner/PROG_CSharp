/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio10
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 02/12/2019						VERSION: 1.0
 * COMENTARIO: Programa que cálcula y muestra el tríangulo de pascal con un nivel dado.
 *---------------------------------------------------------------------- */
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
