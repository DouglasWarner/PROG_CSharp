/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/12/2019						VERSION: 1.0
 * COMENTARIO: Función que valida un código EAN.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string codEAN = string.Empty;
            
            Console.WriteLine("Esta aplicación valida un código EAN.");
            Console.Write("Dime el código: ");
            codEAN = Console.ReadLine();

            if(codEAN.Length != 8 && codEAN.Length != 13)
            {
                Console.WriteLine("El código introducido no es correcto.");
                Console.ReadLine();
                return;
            }

            if (codEAN.Length == 8)
            {
                if (ValidarEan8(codEAN))
                    MostrarMensajeTrue(codEAN);
                else
                    Console.WriteLine("\n\tEl codigo EAN no es correcto");
            }
            if (codEAN.Length == 13)
            {
                if (ValidarEan13(codEAN))
                    MostrarMensajeTrue(codEAN);
                else
                    Console.WriteLine("\n\tEl codigo EAN no es correcto");
            }

            Console.ReadLine();
        }
        
        static void MostrarMensajeTrue(string ean)
        {
            Console.Write("\n\tEl código EAN {0}", ean.Substring(0, ean.Length-1));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(ean.Substring(ean.Length-1, 1));
            Console.ResetColor();
            Console.Write(" es correcto.");
        }

        static bool ValidarEan8(string ean)
        {
            long resultado = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            string dc = ean.Substring(ean.Length - 1,1);

            try
            {
                for (int i = 0; i < ean.Length - 1; i++)
                {
                    int tmp = int.Parse(ean[i].ToString());
                    if (tmp % 2 == 1)
                        sumaImpar += tmp;
                    if (tmp % 2 == 0)
                        sumaPar += tmp;
                }

                resultado = (sumaImpar * 3) + sumaPar;
                resultado %= 10;
                resultado = 10 - resultado;

                if (resultado == 10)
                    resultado = 0;

                return String.Equals(resultado.ToString(), dc) ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static bool ValidarEan13(string ean)
        {
            long resultado = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            string dc = ean.Substring(ean.Length - 1, 1);

            try
            {
                for (int i = 0; i < ean.Length - 1; i++)
                {
                    int tmp = int.Parse(ean[i].ToString());
                    if (tmp % 2 == 1)
                        sumaImpar += tmp;
                    if (tmp % 2 == 0)
                        sumaPar += tmp;
                }

                resultado = (sumaPar * 3) + sumaImpar;
                resultado %= 10;
                resultado = 10 - resultado;

                if (resultado == 10)
                    resultado = 0;

                return String.Equals(resultado.ToString(), dc) ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
