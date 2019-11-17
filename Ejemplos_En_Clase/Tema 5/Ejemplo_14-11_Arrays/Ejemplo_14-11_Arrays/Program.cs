using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_14_11_Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            const int TAMANO = 20;
            int[] array = new int[TAMANO];
            int[] array2 = { 1, 11, 22, 33, 44, 55, 66, 77, 88, 99};

            Console.WriteLine("\n\nMatriz sin inicializar");
            MostrarArray(array);

            InicializaNegativo(array);

            Console.WriteLine("\n\nMatriz inicializada");
            MostrarArray(array);

            Console.WriteLine("\n\nMatriz inicializada con multiplo");
            InicializaNegativo(array, 5);
            MostrarArray(array);

            MostrarArrayPosicionModulo(array);

            Console.ReadLine();
        }

        static bool InicializaNegativo(int[] array)
        {
            int valor = -1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = valor;
            }
            return true;
        }

        static void MostrarArray(int[] array)
        {
            Console.WriteLine("\n Contenido del Array \n");
            foreach (int tmp in array)
            {
                Console.Write(tmp + "  ");
            }
        }

        static bool InicializaNegativo(int[] array, int mult)
        {
            int valor = -1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i % mult == 0) ? 100 : valor;
            }

            return true;
        }

        static void MostrarArrayPosicionModulo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" [{0}] -> {1}", i, array[i%array.Length]);
            }
        }
    }
}
