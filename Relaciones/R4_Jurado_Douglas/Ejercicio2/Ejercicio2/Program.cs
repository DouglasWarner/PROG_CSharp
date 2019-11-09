/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio2
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Imprime por pantalla N veces el caracter que se indique por teclado.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ImprimirNVecesUnCaracter
    {
        static void Main(string[] args)
        {
            char caracter = ' ';
            int nVeces = 0;

            Console.WriteLine("Esta aplicación imprime una caracter tantas veces como se indique.");
            Console.Write("Dime el caracter: ");
            try
            {
                caracter = char.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException eANE)
            {
                Console.WriteLine(eANE.Message);
            }
            catch (FormatException eFE)
            {
                Console.WriteLine(eFE.Message);
            }

            Console.Write("\nDime el entero: ");
            try
            {
                nVeces = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException eANE)
            {
                Console.WriteLine(eANE.Message);
            }
            catch (FormatException eFE)
            {
                Console.WriteLine(eFE.Message);
            }

            Console.WriteLine(PintaCaracteres(nVeces,caracter));

            Console.ReadLine();
        }

        static string PintaCaracteres(int veces, char carac)
        {
            return "".PadLeft(veces, carac);
        }
    }
}
