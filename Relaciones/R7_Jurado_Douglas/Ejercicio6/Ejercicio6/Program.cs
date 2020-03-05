/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio6
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 13/02/2020						VERSION: 1.0
 * COMENTARIO: Esta aplicación gestiona fechas, incluyendo los años bisiestos.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string pedirFecha = string.Empty;
            CFechas fecha = new CFechas();

            Console.WriteLine("\n\t\t GESTION DE FECHAS");
            Console.WriteLine("".PadLeft(60,'='));
            Console.Write("\n\t Escribe la fecha: ");
            pedirFecha = Console.ReadLine();
            fecha.ValidarFecha(pedirFecha);

            Console.ReadLine();
        }
    }
}
