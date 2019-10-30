/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Dado un número introducido por teclado menor que 10000. 
 *              Imprime todos los números primos menor que el.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class NumerosPrimos
    {
        static void Main(string[] args)
        {
            string tmp = string.Empty;
            int numero = 0;
            Console.WriteLine("Esta aplicación cálcula todos los numeros primos hasta 10000 o hasta el número introducido menor de 10000.");
            Console.Write("Dime el número: ");
            
            tmp = Console.ReadLine();

            if (!int.TryParse(tmp, out numero))
            {
                Console.WriteLine("Porfavor introduce un número");
                Console.ReadLine();
                return;
            }

            if (numero > 10000)     // Establezco el máximo a 10000 si el usuario hubiese introducido un número mayor.
                numero = 10000;

            for (int i = 1; i <= numero; i++)
            {
                if(EsPrimo(i))
                    Console.WriteLine("{0} --> Es primo",i);
            }
            Console.ReadLine();
        }

        static bool EsPrimo(int num)
        {
            int contador = 0;

            if (num < 2)
                return false;
            if (num == 2 || num == 3)
                return true;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    contador++;
                if (contador > 2)
                    return false;
            }

            return true;
        }
    }
}
