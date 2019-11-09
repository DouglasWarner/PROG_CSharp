/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Halla el número máximo y el mínimode los introducidos por teclado.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int max = 0;
            int min = 0;

            Console.WriteLine("Esta aplicación cálcula el máximo y el mínimo de los números introdudidos por teclado, hasta introducir un 0.");
            Console.Write("Introduce los números: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
                min = numero;
                max = numero;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return;
            }

            while (numero != 0)
            {
                if (max < numero)
                    max = numero;
                if (min > numero)
                    min = numero;
                try
                {
                    numero = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("El número máximo es: {0}", max.ToString().PadLeft(max.ToString().Length));
            Console.WriteLine("El número mínimo es: {0}", min.ToString().PadLeft(max.ToString().Length));
            Console.ReadLine();
        }
    }
}
