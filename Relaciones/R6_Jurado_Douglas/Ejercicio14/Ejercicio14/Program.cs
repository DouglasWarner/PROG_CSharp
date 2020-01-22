/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 16/01/2020						VERSION: 1.0
 * COMENTARIO: Programa que cuente el número de veces que aparece cada una de las letras de un texto introducido por el
teclado y a continuación imprima el resultado.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            Console.WriteLine(" Esta aplicación contabiliza cada letra del abecedario que sabe en un texto.");
            Console.WriteLine(" A continuación introduce el texto.");
            texto = Console.ReadLine();

            MostrarContadores(ContarLetras(texto));

            Console.ReadLine();
        }

        static int[] ContarLetras(string texto)
        {
            int[] contadores = new int[26];

            for (int i = 0; i < texto.Length; i++)
            {
                int tmp = (int)texto[i] - 97;
                if(tmp >= 1 && tmp < 26)
                    contadores[tmp]++;
            }

            return contadores;
        }

        static void MostrarContadores(int[] contadores)
        {
            Console.WriteLine("\n\n");
            for (int i = (int)'a'; i <= (int)'z'; i++)
            {
                Console.Write("{0}  ", ((char)i).ToString().PadLeft(2));
            }
            Console.WriteLine();
            Console.WriteLine("".PadLeft(100,'-'));
            foreach (int tmp in contadores)
            {
                Console.Write("{0}  ",tmp.ToString().PadLeft(2));
            }
        }


    }
}
