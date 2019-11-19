/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio5
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/11/2019						VERSION: 1.0
 * COMENTARIO: Busca un dato con el algoritmo de búsqueda binaria en un array ordenado, con el algoritmo de ordenamiento de burbuja, 
 *             de números enteros aleatorios.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int numero = 0;
            int posNumBuscado = 0;

            Console.WriteLine("Esta aplicación busca un dato en un array de números enteros aleatorios.\nEl array tiene que estar ordenado.");

            array = InicializarArrayAlea(array, 50);

            if (OrdenarBurbuja(array))
                Console.WriteLine("\nArray ordenado correctamente");
            else
            {
                Console.WriteLine("Error al ordenar el array");
                return;
            }

            MostrarArray(array);
            try
            {
                Console.Write("\nDime que dato quieres buscar: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            posNumBuscado = BusquedaBinaria(array, numero);

            if (posNumBuscado != -1)
                Console.WriteLine("El Dato fue encontrado en la posición: {0}",posNumBuscado);
            else
                Console.WriteLine("El Dato no se encuentra en la lista.");
                
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

            return (a[0] < a[a.Length - 1]) ? true : false;
        }

        static void MostrarArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", i, a[i]);
            }
        }

        static int BusquedaBinaria(int[] a, int numeroABuscar)
        {
            int posInicio = 0;
            int posFinal = a.Length - 1;
            int indice = 0;

            while (a[indice] != numeroABuscar && posInicio <= posFinal)
            {
                indice = (posInicio + posFinal) / 2;
                if (numeroABuscar > a[indice])
                    posInicio = indice + 1;
                else
                    posFinal = indice - 1;
            }
            if (a[indice] == numeroABuscar)
                return indice;

            return -1;
        }
    }
}
