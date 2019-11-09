/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio11
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Muestra todos los parametros pasados por consola.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta aplicación muestra los argumentos pasados por consola.\n");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("[{0}] --> {1}", i, args[i]);
            }

            Console.WriteLine("\nSe han pasado {0} parametros.", args.Length);

            Console.ReadLine();
        }
    }
}
