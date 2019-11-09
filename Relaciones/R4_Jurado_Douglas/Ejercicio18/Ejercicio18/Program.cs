/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio18
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula si dado un año pasado por teclado es bisiesto o no.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = 0;

            try
            {
                Console.WriteLine("Esta aplicación cálcula si el año pasado es bisiesto o no");
                Console.Write("Dime el año: ");
                anio = int.Parse(Console.ReadLine());
                if(EsBisiesto(anio))
                    Console.WriteLine("El año {0} es bisiesto",anio);
                else
                    Console.WriteLine("El año {0} no es bisiesto",anio);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static bool EsBisiesto(int anio)
        {
            return ((anio % 4 == 0 && !(anio % 100 == 0)) || anio % 400 == 0) ? true : false;
        }
    }
}
