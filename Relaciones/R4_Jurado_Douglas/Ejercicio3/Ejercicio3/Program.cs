/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio3
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Pide por N número por teclado y comprueba cada nuúmero si es primo o no.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class NumeroPrimo
    {
        static void Main(string[] args)
        {
            int numero = 1;

            Console.WriteLine("Esta aplicación muestra si el número introducido es primo o no. Introduce un cero para salir.");

            while (numero != 0)
            {
                Console.Write("Dime un número: ");
                try
                {
                    numero = int.Parse(Console.ReadLine());

                    if (EsPrimo(numero))
                        Console.WriteLine("El número {0} es primo.", numero);
                    else
                        Console.WriteLine("El número {0} no es primo.", numero);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }

            }
            Console.ReadLine();
        }

        static bool EsPrimo(int num)
        {
            int contador = 0;

            if (num <= 1)
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
