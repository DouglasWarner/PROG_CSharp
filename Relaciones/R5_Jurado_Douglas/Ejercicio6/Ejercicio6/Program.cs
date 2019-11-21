using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 20;
            const int Y = 20;
            int[,] array2D = new int[X, Y];

            Console.WriteLine("Esta aplicación iniciliza y muestra un array de 2 dimensiones. Y la copia a otra array.");
            Console.WriteLine();


            Console.ReadLine();
        }

        static void InicializarArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        static void MostrarArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
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
