/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula la suma de los primeros números hasta el número pasado por teclado de forma recursiva.
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

            int numero = 0;

            Console.WriteLine("Esta aplicación resulve la suma de los primeros N números de forma recursiva.");
            Console.Write("Dime un número: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es: {0}", SumaRecursiva(numero));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static int SumaRecursiva(int num)
        {
            if (num < 1)
                return 0;
            return num + SumaRecursiva(--num);
        }
    }
}
