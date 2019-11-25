/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio6
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 20/11/2019						VERSION: 1.0
 * COMENTARIO: Inicializa a 0 una matriz de 20x20 de números enteros, luego la inicializa a número aleatorios y la muestra. Tambien copia la matriz a otra matriz.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static int[,] array2D = null;

        static void Main(string[] args)
        {
            const int X = 20;
            const int Y = 20;
            array2D = new int[X, Y];
            int[,] array2DDestino = null;

            Console.WriteLine("Esta aplicación iniciliza y muestra un array de 2 dimensiones. Y la copia a otra array.");
            Console.WriteLine();
            Console.WriteLine("     Matriz 20x20 inicializada a 0, y la muestra.");
            Console.WriteLine("--------------------------------------------------------------------------");
            MostrarArray(array2D);
            Console.WriteLine("\n   Inicializa la matriz 20x20 con números enteros, y la muestra.");
            Console.WriteLine("--------------------------------------------------------------------------");
            ArrayAlea(array2D);
            MostrarArray(array2D);
            Console.WriteLine("\n   Copia la matriz 20x20 a otra matriz 20x20, y la muestra.");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(" Array Destino");
            MostrarArray(array2DDestino);
            Console.WriteLine();
            array2DDestino = CopiarArray();
            Console.WriteLine(" Array copiado");
            MostrarArray(array2DDestino);

            Console.ReadLine();
        }

        static void MostrarArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        static bool ArrayAlea(int[,] array)
        {
            Random rnd = new Random();
            int valorMaximo = 50;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(valorMaximo);
                }
            }
            return true;
        }

        static int[,] CopiarArray()
        {
            int[,] arrayTmp = null;

            if (array2D == null)
                return null;
                
            arrayTmp = new int[array2D.GetLength(0),array2D.GetLength(1)];

            for (int i = 0; i < arrayTmp.GetLength(0); i++)
                for (int j = 0; j < arrayTmp.GetLength(1); j++)
                    arrayTmp[i,j] = array2D[i,j];

            return arrayTmp;
        }
        static bool CopiarArray(int[,] arrayOriginal, int[,] arrayDestino)
        {
            for (int i = 0; i < arrayOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOriginal.GetLength(1); j++)
                {
                    arrayDestino[i, j] = arrayOriginal[i, j];
                }
            }
            return true;
        }
    }
}
