/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio17
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Dado tres números, se determina si la suma de dos de ellos es igual al tercer número.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class ComprobarIgualdad
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string tmp = string.Empty;

            Console.WriteLine("Esta aplicación comprueba si la suma de dos valores son iguales a tercer valor.");
            Console.Write("Dime el primer número: ");

            tmp = Console.ReadLine();
            if(!int.TryParse(tmp, out num1))
            {
                Console.WriteLine("Porfavor introduce un número");
                Console.ReadLine();
                return;
            }

            Console.Write("\nDime el segundo número: ");
            tmp = Console.ReadLine();
            if (!int.TryParse(tmp, out num2))
            {
                Console.WriteLine("Porfavor introduce un número");
                Console.ReadLine();
                return;
            }

            Console.Write("\nDime el tercer número: ");
            tmp = Console.ReadLine();
            if (!int.TryParse(tmp, out num3))
            {
                Console.WriteLine("Porfavor introduce un número");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\n");

            if(SonIguales(num1, num2, num3))
                Console.WriteLine("Iguales");
            else
                Console.WriteLine("Distintos");

            Console.ReadLine();
        }

        static bool SonIguales(int n1, int n2, int n3)
        {
            if (((n1 + n2) == n3) || ((n1 + n3) == n2) || ((n2 + n3) == n1))
                return true;
            return false;
        }
    }
}
