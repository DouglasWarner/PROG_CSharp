/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio15
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula la suma de los primeros números hasta el número introducido de forma iterativa.
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
            int numero = 0;

            Console.WriteLine("Esta aplicación resulve la suma de los primeros N números de forma iterativa.");
            Console.Write("Dime un número: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es: {0}", SumaIterativa(numero));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static int SumaIterativa(int num)
        {
            int resultado = 0;

            for (int i = 0; i <= num; i++)
                resultado += i;

            return resultado;
        }
    }
}
