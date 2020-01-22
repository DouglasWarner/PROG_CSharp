/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 15/01/2020						VERSION: 1.0
 * COMENTARIO: Devuelve un texto a mayuscula.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder texto = new StringBuilder();
            Console.WriteLine("     Esta aplicación devuelve una cadena de texto a mayuscula.");
            Console.WriteLine("     A continuación escribe el texto.");
            Console.WriteLine("".PadLeft(50,'-'));
            texto.Append(Console.ReadLine());

            Console.WriteLine("\n\n     Texto a mayusculas");
            Console.WriteLine("".PadLeft(50, '-'));
            Console.WriteLine(AMayuscula(texto.ToString()));

            Console.ReadLine();
        }

        static string AMayuscula(string texto)
        {
            int offset = (int)'a' - (int)'A';
            StringBuilder tmp = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                tmp.Append((char)(texto[i] - offset));
            }

            return tmp.ToString();
        }
    }
}


/*
            bool esEspacio = false;
            string t = "Hola    caracola";
            int c = 0;
            for (int i = 0; i < t.Length; i++)
			{
			    if(t[i] == ' ' && !esEspacio)
                {
                    c++;
                    esEspacio = true;
                }
                 else
                     esEspacio = false;
			}

            Console.WriteLine(c);
            Console.ReadLine();
*/