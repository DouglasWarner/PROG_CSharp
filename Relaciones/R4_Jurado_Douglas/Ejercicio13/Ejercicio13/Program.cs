/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio13
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula el factorial de forma iterativa de un número pasado por teclado, hasta el 20.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class FactorialIterativo
    {
        static void Main(string[] args)
        {
            long numero = 0;

            Console.WriteLine("Esta aplicación cálcula la factorial de un número hasta el 20 como máximo de forma iterativa.");
            Console.Write("Dime el número a cálcular: ");
            try
            {
                numero = long.Parse(Console.ReadLine());
                if (numero > 20)
                {
                    Console.WriteLine("Porfavor el número debe ser menor que 20.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("El factorial de {0} vale: {1}", numero, FactorialI(numero));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static long FactorialI(long num)
        {
            long resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
