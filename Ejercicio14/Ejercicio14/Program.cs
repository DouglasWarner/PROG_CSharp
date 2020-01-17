using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        /*Escribir un programa que cuente el número de veces que aparece cada una de las letras de un texto introducido por el
teclado y a continuación imprima el resultado. Para hacer el ejemplo sencillo, vamos a suponer que el texto sólo contiene
letras minúsculas del alfabeto inglés (no hay ni letras acentuadas, ni la //, ni la ñ). La solución podría ser de la forma
siguiente:*/
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
