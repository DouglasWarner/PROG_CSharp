/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio19
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Convierta las millas marinas en metros. 1 milla marina equivale a 1.852 metros.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class MetrosAMillasMarinas
    {
        static void Main(string[] args)
        {
            const int METROS = 1852;
            int milla = 0;
            
            Console.WriteLine("Esta aplicación convierte la millas marinas en metros");

            Console.WriteLine("Dime cuantas millas marinas quieres en metros: ");
            try
            {
                milla = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} millas marinas son -> {1} metros", milla, milla * METROS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
