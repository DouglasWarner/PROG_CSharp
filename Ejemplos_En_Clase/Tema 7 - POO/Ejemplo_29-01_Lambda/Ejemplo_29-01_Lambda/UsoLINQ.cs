using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_29_01_Lambda
{
    class UsoLINQ
    {

        public void MetodoMain()
        {
            // Obtener los valores impares
            int[] numeros = Crear();
            int numeroImpares = numeros.Count<int>(n => n % 2 == 1);

            Console.WriteLine("\n\tHay estos impares {0}", numeroImpares);

            Console.ReadLine();
        }

        static int[] Crear()
        {
            int[] datos = new int[1000000];
            Random rnd = new Random();
            int max = 50000;
            int min = 5000;

            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = rnd.Next(min, max);
            }

            return datos;
        }
    }
}
