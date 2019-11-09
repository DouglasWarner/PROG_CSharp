/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio17
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula una división pasando por teclado el dividendo y el divisor.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;

            Console.WriteLine("Esta aplicación cálcula el resto de una división.");

            try
            {
                Console.Write("Dime el dividendo: ");
                divisor = int.Parse(Console.ReadLine());
                Console.Write("Dime el divisor: ");
                dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("El resto de la división de {0} y {1}: {2}", divisor, dividendo, RestoDivision(divisor, dividendo));
            }
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine(dEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static double RestoDivision(int divisor, int dividendo)
        {
            return divisor % dividendo;
        }
    }
}
