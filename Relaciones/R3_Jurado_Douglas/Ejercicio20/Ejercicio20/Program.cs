/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio20
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Cálcula la media de una serie de notas introducidas.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class CalculaNotasMedias
    {
        static void Main(string[] args)
        {
            float notas = 0F;
            double sumNotas= 0;
            int cantNotas = 0;

            Console.WriteLine("Esta aplicación cálcula la media de las notas introducidas, hasta introducir un 0.");

            do
            {
                Console.Write(" {0}. Nota: ", ++cantNotas);
                try
                {
                    notas = float.Parse(Console.ReadLine());
                    if (notas > 10 || notas < 0)
                    {
                        Console.WriteLine("Porfavor introduce una nota válida, entre 0 y 10.");
                        cantNotas--;
                    }
                    else
                        sumNotas += notas;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    return;
                }

            } while (notas != 0);

            Console.WriteLine("La media de las notas introducidas: {0:N}", sumNotas / (cantNotas-1));
            Console.ReadLine();
        }
    }
}
