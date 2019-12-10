using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CrearArrayAlea();
            
            MostrarArray(array);
            Console.WriteLine("\n\n");
            ContarValores(array);

            Console.ReadLine();
        }

        /// <summary>
        /// Crea un array con números aleatorios de valores entre -99 y 99
        /// </summary>
        /// <returns>Devuelve un array con los números aleatorios</returns>
        static int[] CrearArrayAlea()
        {
            Random rnd = new Random();
            const int TAMANO = 100;
            int[] numeros = new int[TAMANO];
            int minimo = -99;
            int maximo = 100;

            for (int i = 0; i < numeros.Length; i++)
                numeros[i] = rnd.Next(minimo, maximo);

            return numeros;
        }

        static void ContarValores(int[] array)
        {
            Console.WriteLine(" Muestra la cantidad de valores de cero, posivitos, negativos, impar y par ");
            Console.WriteLine(new string('=',30));
            Console.WriteLine("     Ceros: {0}", array.Count<int>(x => x == 0));
            Console.WriteLine(" Positivos: {0}", array.Count<int>(x => x > 0));
            Console.WriteLine(" Negativos: {0}", array.Count<int>(x => x < 0));
            Console.WriteLine("     Pares: {0}", array.Count<int>(x => x % 2 == 0));
            Console.WriteLine("   Impares: {0}", array.Count<int>(x => x % 2 != 0));

            Console.WriteLine("\n");
            Console.Write("Eso es todo...");
        }

        static void MostrarArray(int[] array)
        {
            foreach (int tmp in array)
            {
                Console.Write(" | ");
                Console.Write("{0,5}", tmp.ToString().PadLeft(3));
            }

            Console.Write(" |");

            Console.WriteLine("\n");
            Console.Write("Pulse cualquier tecla...");
            Console.ReadLine();
        }
    }
}
