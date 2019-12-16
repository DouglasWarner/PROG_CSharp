/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio5
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 16/12/2019						VERSION: 1.0
 * COMENTARIO: Esta aplicación cuenta las palabras de una cadena de texto y un carácter (separador de palabras) y
               devuelva un entero con el número de palabras de la cadena.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string[] SepararPalabras(string texto, char[] separadores)
        {
            return texto.Split(separadores);
        }

    }
}
