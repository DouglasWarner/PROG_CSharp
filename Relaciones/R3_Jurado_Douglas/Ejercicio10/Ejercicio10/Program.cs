/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio10
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Comprueba si dado un número positivo, comprendido entre 7 y 99, es primo o no.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class CalcularPrimo
    {
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
                Console.ReadLine();
                return;
            }

            if (numero < 7 || numero > 99)
            {
                Console.WriteLine("Porfavor introduce un numero entre 7 y 99");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine(EsPrimo(numero) ? numero + "-> Es primo" : numero + "-> No es primo");
            }

            Console.ReadLine();
        }

        static bool EsPrimo(int num)
        {
            int contador = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    contador++;
                if (contador > 2)
                    return false;
            }
            return true;
        }
    }
}
