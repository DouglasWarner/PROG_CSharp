using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_12_R5_Ej2
{
    public struct Contadores
    {
        public int positivos;
        public int negativos;
        public int ceros;
        public int pares;
        public int impares;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = CrearArrayAlea();

            Contadores contar = ContarValores(array);

            MostrarArray(array);

            Console.WriteLine("\n\n");

            MostrarContadores(contar);
            Console.WriteLine("\n\n");

            ContarValoresConLambda(array);

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

        static Contadores ContarValores(int[] array)
        {
            Contadores contar = new Contadores();

            foreach (int tmp in array)
            {
                if (tmp == 0)
                    contar.ceros++;
                if (tmp > 0)
                    contar.positivos++;
                if (tmp < 0)
                    contar.negativos++;
                if (tmp % 2 == 0)
                    contar.pares++;
                else
                    contar.impares++;
            }

            return contar;
        }

        static void ContarValoresConLambda(int[] array)
        {
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
            Console.Write("Eso es todo...");
            Console.ReadLine();
        }

        static void MostrarContadores(Contadores contador)
        {
            Console.WriteLine("     Ceros: {0}", contador.ceros.ToString().PadLeft(5));
            Console.WriteLine(" Positivos: {0}", contador.positivos.ToString().PadLeft(5));
            Console.WriteLine(" Negativos: {0}", contador.negativos.ToString().PadLeft(5));
            Console.WriteLine("     Pares: {0}", contador.pares.ToString().PadLeft(5));
            Console.WriteLine("   Impares: {0}", contador.impares.ToString().PadLeft(5));

            Console.WriteLine("\n");
            Console.Write("Eso es todo...");
        }
    }
}
