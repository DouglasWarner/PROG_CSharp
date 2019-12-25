/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio1
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 15/12/2019						VERSION: 1.0
 * COMENTARIO: Esta aplicación recibe una cadena de texto y la devuelve al revés
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;

            Console.WriteLine("         Esta aplicación devuelve un texto al reves.");
            Console.WriteLine("     ".PadRight(50,'='));
            Console.Write("         Escribe una frase: ");
            frase = Console.ReadLine();

            Console.Write("\n       El texto ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(frase);
            Console.ResetColor();
            Console.Write(" al reves: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(AlReves(frase));
            Console.ResetColor();

            Console.ReadLine();
        }

        static string AlReves(string texto)
        {
            string tmpTexto = string.Empty;

            for (int i = texto.Length - 1; i >= 0; i--)
                tmpTexto += texto[i];
            return tmpTexto;
        }
    }
}
