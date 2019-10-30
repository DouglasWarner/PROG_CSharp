/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio16
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Lee por teclado N caracteres y contabiliza las vocales.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class ContabilizaVocales
    {
        static void Main(string[] args)
        {
            string caracteres = string.Empty;
            Console.WriteLine("Esta aplicación lee por teclado N caracteres, hasta introducir un 0.");
            Console.WriteLine("Y contabiliza todas las vocales");
            Console.WriteLine("Escriba lo que quiera");
            do
            {
                caracteres += Console.ReadLine();

            } while (caracteres[caracteres.Length-1] != '0');

            Console.WriteLine("Hay {0} 'a' ", caracteres.Count<Char>(c => c == 'a'));
            Console.WriteLine("Hay {0} 'e' ", caracteres.Count<Char>(c => c == 'e'));
            Console.WriteLine("Hay {0} 'i' ", caracteres.Count<Char>(c => c == 'i'));
            Console.WriteLine("Hay {0} 'o' ", caracteres.Count<Char>(c => c == 'o'));
            Console.WriteLine("Hay {0} 'u' ", caracteres.Count<Char>(c => c == 'u'));

            Console.ReadLine();
        }
    }
}
