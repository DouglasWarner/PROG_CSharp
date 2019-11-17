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

            LLenarArrayNumerosAleatorio(array);
            Mostrar(array);
            MaximoMinimo(array, out maximo, out minimo);
            Media(array, out media);

            Console.WriteLine("La media de todos los número: {0}", media);
            Console.WriteLine("El máximo es: {0}", maximo);
            Console.WriteLine("El mínimo es: {0}",minimo);

            Console.ReadLine();

        }

        static bool LLenarArrayNumerosAleatorio(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(101);
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
                Console.WriteLine("[{0}] {1}", i, array[i].ToString().PadLeft(3));
            }
            return true;
        }
    }
}
