/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio16
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 08/11/2019						VERSION: 1.0
 * COMENTARIO: Cálcula la potencia de un número de forma recursiva.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double exponente = 0;

            Console.WriteLine("Esta aplicación cálcula la potencia de un número de forma recursiva.");
            try
            {
                Console.Write("Dime la base: ");
                numero = double.Parse(Console.ReadLine());
                Console.Write("Dime el exponente: ");
                exponente = double.Parse(Console.ReadLine());
                
                if(numero == 0)
                    Console.WriteLine("ERROR: La base no puede ser 0.");
                else
                    Console.WriteLine("El resultado de la potencia es: {0}", potenciaRecursiva(numero, exponente));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }


        static double potenciaRecursiva(double numero, double exponente)
        {
            if (exponente == 0 || numero == 1)
                return 1;

            if (exponente < 0)
                return 1 / numero * potenciaRecursiva(numero, exponente+1);

            return numero * potenciaRecursiva(numero, exponente-1);
        }
    }
}
