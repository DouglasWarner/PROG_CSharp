using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class CalcularPrimo
    {
        // Escribir en pseudocódigo si dado un número positivo, comprendodo entre 7 y 99,es primo o no.
        static void Main(string[] args)
        {
            string tmp = string.Empty;
            int numero = 0;

            Console.WriteLine("Introduce un número entre 7 y 99, y te digo si es primo o no.");
            Console.WriteLine("Dime un número");

            tmp = Console.ReadLine();

            if (!int.TryParse(tmp, out numero))
            {
                Console.WriteLine("Porfavor introduce un numero");
                return;
            }

            if (numero < 7 && numero > 99)
            {
                Console.WriteLine("Porfavor introduce un numero entre 7 y 99");
                return;
            }
            else
                Console.WriteLine(EsPrimo(numero) ? "Es primo" : "No es primo");

            Console.ReadLine();
        }

        static bool EsPrimo(int num)
        {
            return (num % 2 == 0) ? false : true;
        }
    }
}
