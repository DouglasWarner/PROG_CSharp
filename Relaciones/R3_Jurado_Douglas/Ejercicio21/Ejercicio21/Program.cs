/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio21
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Genera una quiniela con valores aleatorios de X, 1 y 2.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Quiniela
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] resultado = new char[] { '1', '2', 'x'};
            char[] resultQuiniela = new char[15];

            Console.WriteLine("Generador de resultado de quiniela de futbol");

            CrearQuiniela(rnd, resultado, resultQuiniela);

            MostrarQuiniela(resultado, resultQuiniela, 5, 15);

            Console.ReadLine();
        }

        static void MostrarQuiniela(char[] resultado, char[] resultQuiniela, int posArriba, int posDerecha)
        {
            Console.CursorTop = posArriba;
            foreach (char tmp in resultQuiniela)
            {
                Console.CursorLeft = posDerecha;
                Console.WriteLine(tmp);
            }
            Console.CursorTop++;
            Console.CursorLeft = posDerecha-5;
            Console.WriteLine("Hay {0} de 1, equivale a un {1}%", resultQuiniela.Count<char>(x => x == resultado[0]), 
                                                                (resultQuiniela.Count<char>(x => x == resultado[0]) * 100 / 15).ToString("00.00"));
            Console.CursorLeft = posDerecha-5;
            Console.WriteLine("Hay {0} de 2, equivale a un {1}%", resultQuiniela.Count<char>(x => x == resultado[1]),
                                                                (resultQuiniela.Count<char>(x => x == resultado[1]) * 100 / 15).ToString("00.00"));
            Console.CursorLeft = posDerecha-5;
            Console.WriteLine("Hay {0} de X, equivale a un {1}%", resultQuiniela.Count<char>(x => x == resultado[2]),
                                                                (resultQuiniela.Count<char>(x => x == resultado[2]) * 100 / 15).ToString("00.00"));
        }

        static void CrearQuiniela(Random rnd, char[] resultado, char[] resultQuiniela)
        {
            for (int i = 0; i < resultQuiniela.Length; i++)
            {
                resultQuiniela[i] = resultado[rnd.Next(resultado.Length)];
            }
        }
    }
}
