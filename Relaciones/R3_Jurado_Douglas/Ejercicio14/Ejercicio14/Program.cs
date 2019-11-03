/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Imprime por pantalla distintos tipos de formato de la Clase String.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class FormatoDeSalida
    {
        static void Main(string[] args)
        {
            float s1 = 2.5F;
            int s2 = 25;
            int s3 = 250;
            int s4 = 250000;

            Console.WriteLine("Voy a mostrar dado un valor Integer, distintos tipos de formatos de salida con el método Write.");
            Console.WriteLine("".PadLeft(60,'-'));

            Console.WriteLine("{0:D5}", s2);
            Console.WriteLine("{0:E}", s4);
            Console.WriteLine("{0:N}", s2);
            Console.WriteLine("{0:G}", s2);
            Console.WriteLine("{0}", s1);
            Console.WriteLine("{0:N2}", s4);
            Console.WriteLine("{0:X}", s3);

            string x = "hola caracola";

            Console.WriteLine("{0:*}",x);
            Console.ReadLine();
        }
    }
}
