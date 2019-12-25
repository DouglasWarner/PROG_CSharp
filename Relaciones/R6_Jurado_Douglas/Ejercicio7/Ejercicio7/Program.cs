/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 19/12/2019						VERSION: 1.0
 * COMENTARIO: Función que valida un ISBN.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            char separador = '-';
            string isbn = string.Empty;

            Console.WriteLine("     Esta aplicación valida el ISBN de un libro. Para salir introduce un [ * ].");
            Console.WriteLine("".PadLeft(50,'-'));
            do
            {
                Console.Write("\n   Dime el ISBN: ");
                isbn = Console.ReadLine();

                if (isbn == "*")
                    return;

                if (!ValidarISBN(QuitarGuiones(isbn, separador)))
                    Console.WriteLine("\n\t Error: Algo ocurrio con el ISBN introducido.");
                else
                {
                    Console.Write("El ISBN ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(isbn);
                    Console.ResetColor();
                    Console.Write(" es correcto.");
                }

            } while (true);
        }

        static bool ValidarISBN(string isbn)
        {
            // ISBN de 0 a 9
            // Digito de control de 0 a 9 o X
            // MOD 11. Si el resultado es 10 el dc es X;

            char dc = ' ';
            if (isbn.Length < 0 && isbn.Length > 9)
                return false;

            return false;
        }

        static string QuitarGuiones(string isbn, char separador)
        {
            string[] split = isbn.Split(separador);
            StringBuilder resultado = new StringBuilder();

            foreach (string tmp in split)
            {
                resultado.Append(tmp);
            }

            return resultado.ToString();
        }
    }
}
