/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 13/02/2020						VERSION: 1.0
 * COMENTARIO: Esta aplicación gestiona un conjunto de vehiculos utilizando la herencia.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c = new Coche("Seat",4,ConsoleColor.Red, Vehiculo.TipoTraccion.Delantera, 180);

            c.Marchar();


            Console.ReadLine();

        }
    }
}
