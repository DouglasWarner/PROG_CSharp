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
            string texto = string.Empty;
            string[] palabras = null;
            char separador = ' ';

            Console.WriteLine("     Esta aplicación cuenta las palabras de un texto según un separador.");
            Console.WriteLine("".PadLeft(40, '-'));
            Console.Write(" Escribe el texto: ");
            texto = Console.ReadLine();
            Console.Write(" Dime el separador: ");
            separador = Console.ReadLine()[0];      // Coje el primer char que se escribe.

            palabras = SepararPalabras(texto, separador);

            Console.WriteLine("\n\n");
            Console.WriteLine("\t Texto");
            Console.WriteLine("".PadLeft(40,'-'));
            Console.WriteLine("\t" + texto);
            Console.WriteLine("".PadLeft(40, '-'));
            Console.WriteLine(" Cantidad de palabras: {0}", palabras.Length);

            Console.ReadLine();
        }

        static string[] SepararPalabras(string texto, char separadores)
        {
            return texto.Split(new char[] {separadores}, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
