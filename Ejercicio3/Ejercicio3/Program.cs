/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio3
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/11/2019						VERSION: 1.0
 * COMENTARIO: Dado un array de números enteros entre 0 y 20, muestra la media, el máximo y el mínimo.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int minimo = 0;
            int media = 0;
            int[] array = new int[100];

            Console.WriteLine("Esta aplicación muestra la media, el número máximo y el mínimo de un array de números enteros");
            Console.WriteLine();
            LLenarArrayNumerosAleatorio(array, 20);
            Mostrar(array);
            MaximoMinimo(array, out maximo, out minimo);
            Media(array, out media);

            Console.WriteLine("\n\n La media de todos los número: {0}", media.ToString().PadLeft(2));
            Console.WriteLine("                 El máximo es: {0}", maximo.ToString().PadLeft(2));
            Console.WriteLine("                 El mínimo es: {0}", minimo.ToString().PadLeft(2));

            Console.ReadLine();

        }

        static bool LLenarArrayNumerosAleatorio(int[] array, int num)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(num);
            }
            return true;
        }

        static bool MaximoMinimo(int[] array, out int maximo, out int minimo)
        {
            maximo = 0;
            minimo = array[0];

            foreach (int tmp in array)
            {
                if (maximo < tmp)
                    maximo = tmp;
                if (minimo > tmp)
                    minimo = tmp;
            }

            return true;
        }

        static bool Media(int[] array, out int media)
        {
            media = 0;

            foreach (int tmp in array)
            {
                media += tmp;
            }

            media /= array.Length;

            return true;
        }

        static bool Mostrar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] {1},\t", i, array[i].ToString().PadLeft(3));
            }
            return true;
        }
    }
}
