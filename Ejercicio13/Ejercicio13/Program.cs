/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio13
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 15/01/2020						VERSION: 1.0
 * COMENTARIO: Devuelve una lista de palabras comenzando por mayuscula la primera letra.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("     Esta aplicación devuelve una lista de palabra, de una frase, comenzando por mayuscula cada una.");
            Console.WriteLine("     Escribe a continuación la frase.");
            Console.WriteLine("".PadLeft(50,'-'));
            frase = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            MostrarListaPalabras(Palabras(frase));
            Console.ResetColor();

            Console.ReadLine();
        }

        static void MostrarListaPalabras(string[] palabras)
        {
            foreach (string tmp in palabras)
            {
                Console.WriteLine("\n\t{0}", tmp);
            }
        }

        static string[] Palabras(string frase)
        {
            char[] separadores = { ' ', '-', '|', ',', ';' };
            string[] palabras = frase.Split(separadores);

            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].Replace(palabras[i][0].ToString(), palabras[i][0].ToString().ToUpper());
            }

            return palabras;
        }
    }
}
