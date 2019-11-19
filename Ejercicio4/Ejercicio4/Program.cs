/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio4
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/11/2019						VERSION: 1.0
 * COMENTARIO: Dado un array de 20 números enteros aleatorios, se ordena con el algoritmo de la burbuja.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Console.WriteLine("Esta aplicación ordena un array de números enteros, inicializado aleatoriamente, \ncon el algoritmo de la burbuja.");
            array = InicializarArrayAlea(array, 50);

            MostrarArray(array);

            if (OrdenarBurbuja(array))
            {
                Console.WriteLine("\nArray Ordenado con el algoritmo de la burbuja");
                Console.WriteLine("----------------------------------------------------------");
                MostrarArray(array);
            }
            else
                Console.WriteLine("Error al ordenar el array");


            Console.ReadLine();
        }

        static int[] InicializarArrayAlea(int[] a, int numAlea)
        {
            Random rnd = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(numAlea);
            }

            return a;
        }

        static bool OrdenarBurbuja(int[] a)
        {
            int aux = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
            }

            return (a[0] < a[a.Length-1]) ? true : false;
        }

        static void MostrarArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", i, a[i]);
            }
        }
    }
}
