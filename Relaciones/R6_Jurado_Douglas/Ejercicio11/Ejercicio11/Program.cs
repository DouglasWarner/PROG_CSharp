/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio11
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/12/2019						VERSION: 1.0
 * COMENTARIO: Función que convierte un número entre 0 y 999.999 escrito en letra.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static readonly string[] unidades = { "", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
        static readonly string[] decimales1 = { "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
        static readonly string[] decimales2 = { "", "", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
        static readonly string[] centenas = { "", "CIEN", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

        static void Main(string[] args)
        {
            string numero = string.Empty;
            long tmpNum = 0;

            Console.WriteLine("Esta aplicación convierte el número introducido en letra");
            Console.Write("Introduce el número: ");
            numero = Console.ReadLine();

            try
            {
                tmpNum = long.Parse(numero);
            }
            catch (Exception)
            {
                Console.Write("Error: Algo ocurrio con el numero introducido.");
                Console.ReadLine();
                return;
            }

            Console.Write("El número ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(numero);
            Console.ResetColor();
            Console.Write(" en letras es: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ConvertirALetra(tmpNum));
            Console.ResetColor();


            Console.ReadLine();
        }

        static string ConvertirALetra(long numero)
        {
            switch (numero.ToString().Length)
            {
                case 1:
                    return unidades[numero];
                case 2:
                    return ObtenerDecimales(numero);
                case 3:
                    return ObtenerCentenas(numero);
                default:
                    return ObtenerMiles(numero);
            }
        }

        static string ObtenerDecimales(long num)
        {
            string tmpNum = num.ToString();

            if (tmpNum[tmpNum.Length - 2] == '1')
                return decimales1[long.Parse(tmpNum.Substring(tmpNum.Length-1,1))];
            else
            {
                if (tmpNum[tmpNum.Length - 1] == '0')
                    return decimales2[long.Parse(tmpNum.Substring(tmpNum.Length - 2, 1))];
                else
                    return decimales2[long.Parse(tmpNum.Substring(tmpNum.Length - 2, 1))] + " Y " + unidades[long.Parse(tmpNum.Substring(tmpNum.Length - 1, 1))];
            }
        }

        static string ObtenerCentenas(long num)
        {
            string tmpNum = num.ToString();
            
            if(tmpNum[tmpNum.Length - 2] == '0')
                return centenas[long.Parse(tmpNum.Substring(tmpNum.Length - 3, 1))] + " " + unidades[long.Parse(tmpNum.Substring(tmpNum.Length - 1, 1))];

            return centenas[long.Parse(tmpNum.Substring(tmpNum.Length - 3, 1))] + " " + ObtenerDecimales(num);
        }

        static string ObtenerMiles(long num)
        {
            string tmpNum = num.ToString();

            if (tmpNum.Length == 4)
                return unidades[long.Parse(tmpNum[0].ToString())] + " MILL " + ObtenerCentenas(num);
            if (tmpNum.Length == 5)
                return ObtenerDecimales(long.Parse(tmpNum.Substring(0,2))) + " MILL " + ObtenerCentenas(num);
            
            return ObtenerCentenas(long.Parse(tmpNum.Substring(0, 3))) + " MILL " + ObtenerCentenas(num);
        }
    }
}
