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
                    Console.WriteLine("\n\tEl ISBN no es correcto. Vuelva a intertarlo.");
                else
                {
                    Console.Write("\n\tEl ISBN ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(isbn);
                    Console.ResetColor();
                    Console.Write(" es correcto.\n");
                }

            } while (true);
        }

        static bool ValidarISBN(string isbn)
        {
            // ISBN de 0 a 9
            // Digito de control de 0 a 9 o X
            // MOD 11. Si el resultado es 10 el dc es X;

            char dc = ' ';
            int nVueltas = 9;
            long resultado = 0;

            if (isbn.Length < 0 || isbn.Length > 10)
                return false;

            try
            {
                dc = char.ToUpper(isbn[isbn.Length - 1]);

                for (int i = 0; i < nVueltas; i++)
                {
                    resultado += int.Parse(isbn[i].ToString()) * (i + 1);
                }

                resultado %= 11;

                if (resultado == 10 && dc == 'X')
                    return true;

                return String.Equals(resultado.ToString(), dc.ToString());
            }
            catch (Exception)
            {
                return false;
            }
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
