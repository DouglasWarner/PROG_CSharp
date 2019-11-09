/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula el factorial de forma recursiva de un número pasado por teclado, hasta el 20.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class FactorialRecursiva
    {
        static void Main(string[] args)
        {
            long numero = 0;

            Console.WriteLine("Esta aplicación cálcula la factorial de un número hasta el 20 como máximo de forma recursiva.");
            Console.Write("Dime el número a cálcular: ");
            try
            {
                numero = long.Parse(Console.ReadLine());
                if (numero > 20)
                {
                    Console.WriteLine("Porfavor el número debe ser menor que 20.");
                    return;
                }
                Console.WriteLine("El factorial de {0} vale: {1}", numero, FactorialR(numero));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static long FactorialR(long n)
        {
            if (n < 1)
                return 1;
            return n-- * FactorialR(n);
        }
    }
}
