/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio19
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula los conejos de Fibonacci con una función recursiva.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses = 0;
            Console.WriteLine("Esta aplicación cálcula el algoritmo de los conejos de Fibonacci mediante una función recursiva.");
            Console.WriteLine("Pasandole los meses por teclado.");
            Console.Write("Dime los meses: ");

            try
            {
                meses = int.Parse(Console.ReadLine());
                if(meses <= 0)
                {
                    Console.WriteLine("Error: Porfavor introduce una cantidad correcta.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("En {0} meses han nacido {1} par de conejos.",meses, Fibonacci(meses-1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static int Fibonacci(int meses)
        {
            if (meses == 1 || meses == 0)
                return 1;

            return Fibonacci(meses - 1) + Fibonacci(meses - 2);
        }
    }
}