/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio10
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/12/2019						VERSION: 1.0
 * COMENTARIO: Función que valida el código IBAN de una cuenta bancaria.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuenta = string.Empty;

            Console.WriteLine("Esta aplicación valida el código IBAN de una cuenta bancaria española.");
            Console.Write("Introduce una cuenta bancaria: ");
            cuenta = Console.ReadLine().Replace(" ", "").ToUpper();

            if(cuenta.Length != 24)
            {
                Console.Write("\n\tError: Algo ocurrio con la cuenta bancaria introducida.");
                return;
            }

            if(!string.Equals(string.Concat(cuenta[0],cuenta[1]), "ES"))
            {
                Console.Write("\n\tLa cuenta bancaria debe ser de España - ES.");
                Console.ReadLine();
                return;
            }
            
            if (ValidarIban(cuenta))
            {
                MostrarMensajeValido(cuenta);
            }
            else
                Console.WriteLine("No es valido");

            Console.ReadLine();

        }
        
        static void MostrarMensajeValido(string iban)
        {
            string dc = iban.Substring(0, 4);

            Console.Write("El iban");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" {0}", dc);
            Console.ResetColor();
            Console.Write("{0} es valido.", iban.Substring(dc.Length-1));
        }

        static bool ValidarIban(string cc)
        {
            StringBuilder iban = new StringBuilder(cc);
            long resultado = 0;
            string dc = string.Concat(cc[2], cc[3]);

            iban.Append("ES00");

            iban.Remove(0, 4);
            iban.Replace("ES", "1428");

            try
            {
                resultado = 98 - (CálcularModulo(iban));

                return string.Equals(resultado.ToString("00"), dc);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        static long CálcularModulo(StringBuilder iban)
        {
            long x1 = long.Parse(iban.ToString().Substring(0,iban.Length/2)) % 97; // Modulo de la primera mitad IBAN
            long x2 = long.Parse(String.Concat(x1.ToString(),iban.ToString().Substring(iban.Length / 2))) % 97; // Modulo de la segunda mitad IBAN

            return x2;
        }
    }
}
