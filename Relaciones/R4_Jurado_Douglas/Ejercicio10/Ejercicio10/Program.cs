/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio10
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula el valor absoluto de un número pasado por teclado.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Esta aplicación cálcula el valor absoluto de un número pasado por teclado.");
            Console.Write("Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor absoluto de {0} es {1}", numero, ValorAbsoluto(numero));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static int ValorAbsoluto(int num)
        {
            return (num < 0) ? -(num) : num;
        }
    }
}
