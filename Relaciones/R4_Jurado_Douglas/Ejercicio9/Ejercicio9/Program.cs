/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio9
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Halla la media de una serie de números introducidos por teclado, hasta introducir un 0.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class CalcularMedia
    {
        static void Main(string[] args)
        {
            double numero = 1;
            double sumatoria = 0;
            double nCantidad = -1;
            Console.WriteLine("Esta aplicación cálcula la media de la serie de números introducidos.");
            Console.WriteLine("Introduce los números.");

            while (numero != 0)
            {
                try
                {   
                    numero = double.Parse(Console.ReadLine());
                    nCantidad++;
                    sumatoria += numero;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("La media de los números introducidos: {0:F}", sumatoria / nCantidad);
            Console.ReadLine();
        }
    }
}
