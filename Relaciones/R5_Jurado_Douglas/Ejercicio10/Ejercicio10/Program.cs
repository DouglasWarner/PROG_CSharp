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
        static long[,] piramide = null;

        static void Main(string[] args)
        {
            Console.WindowWidth += 50;
            PiramidePascal(20);     // Piramide de pascal como máximo un nivel de 20.
            MostrarPiramidePascal();
            
            Console.Write("\n Eso es todo... ");
            Console.ReadLine();
        }

        static void MostrarPiramidePascal()
        {
            int posicion = piramide.GetLength(0) + piramide.GetLength(1) - 2;

            for (int i = 0; i < piramide.GetLength(0); i++)
            {
                Console.CursorLeft = posicion * 2;
                for (int j = 0; j < piramide.GetLength(1); j++)
                {
                    Console.Write("{0}", (piramide[i,j] == 0) ? " " : piramide[i,j].ToString().PadLeft(8));
                }
                posicion -= 2;
                Console.WriteLine();
            }
        }

        static long[,] PiramidePascal(long tamano)
        {
            piramide = new long[tamano, tamano];

            piramide[0, 0] = 1; // Posicion primera de la piramide.

            for (long i = 1; i < piramide.GetLength(0); i++)
            {
                for (long j = 0; j <= i; j++)
                {
                    piramide[i, j] = Factorial(i) / (Factorial(j) * Factorial(i - j));
                }
            }

            return piramide;
        }

        static long Factorial(long numero)
        {
            if (numero < 1)
                return 1;

            return numero * Factorial(numero - 1);
        }
    }
}
