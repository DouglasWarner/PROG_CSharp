/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio15
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/01/2020						VERSION: 1.0
 * COMENTARIO: Cálcula si un texto es palindromo o no.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder texto = new StringBuilder();
            int resultado = 0;

            Console.WriteLine("     Esta aplicación cálcula si un texto es palindromo.");
            Console.Write("     Escribe el texto: ");
            texto.Append(Console.ReadLine());
            resultado = EsPalindromo(texto);

            if(resultado == -1)
            {
                Console.Write("\n\t El texto ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}", texto);
                Console.ResetColor();
                Console.Write(" es palindromo.", texto);
            }
            else
            {
                Console.WriteLine("\n\t El texto {0} no es palindromo.", texto);
                Console.Write("\n\t Por la letra de la posición ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}", resultado);
                Console.ResetColor();
                Console.Write(" en el texto ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0}", texto.ToString());
                Console.ResetColor();
                Console.Write(" dejan de se iguales.");
            }

            Console.ReadLine();
        }

        static int EsPalindromo(StringBuilder texto)
        {
            char[] separadores = { ' ', ',', ';' };
            string[] tmp = texto.ToString().Split(separadores);
            StringBuilder textoAlreves = new StringBuilder();
            texto.Clear();

            foreach (string item in tmp)
            {
                texto.Append(item);
            }

            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                for (int j = tmp[i].Length - 1; j >= 0; j--)
                {
                    textoAlreves.Append(tmp[i][j]);
                }
            }

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != textoAlreves[i])
                    return i;
            }

            return -1;
        }
    }
}
