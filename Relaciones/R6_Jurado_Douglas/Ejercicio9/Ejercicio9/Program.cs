/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio9
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/12/2019						VERSION: 1.0
 * COMENTARIO: Función que valida el código de una cuenta corriente.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuenta = string.Empty;
            int[] numeros = { 4, 8, 5, 10, 9, 7, 3, 6, 0, 0, 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            while (true)
            {
                Console.WriteLine("Esta aplicación valida el código de una cuenta corriente.");
                Console.Write("\nIntroduce la cuenta corriente sin guiones: ");
                cuenta = Console.ReadLine();

                cuenta = cuenta.Replace(" ", ""); // Quitar los espacios en blanco entre número de sucursal, banco, etc...

                if (cuenta.Length != 20)
                {
                    Console.Write("\n\tError: Algo ha pasado al introducir la cuenta corriente. Intentelo de nuevo.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                
                if (ValidarCC(cuenta, numeros))
                {
                    MensajeEsValido(cuenta);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.Write("\n\tLa cuenta no es valida.");
                    Console.ReadLine();
                    return;
                }
            }
        }

        static void MensajeEsValido(string cc)
        {
            string cc1 = cc.Substring(0, 8);
            string cc2 = cc.Substring(cc.Length / 2, 10);
            string dc1 = cc[cc1.Length].ToString();
            string dc2 = cc[cc1.Length+1].ToString();

            Console.Write("\n\tLa cuenta corriente {0}", cc1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" {0}{1} ",dc1,dc2);
            Console.ResetColor();
            Console.Write(cc2);
            Console.Write(" es valida.");
        }

        static bool ValidarCC(string cc, int[] numeros)
        {
            int indiceMitadCC = cc.Length / 2;
            long resultado1 = 0;
            long resultado2 = 0;
            string dc1 = cc[indiceMitadCC - 2].ToString();
            string dc2 = cc[indiceMitadCC - 1].ToString();

            try
            {
                resultado1 = CalcularDC1(cc, numeros, indiceMitadCC);
                resultado2 = CalcularDC2(cc, numeros, indiceMitadCC);

                if (resultado1 == 10)
                    resultado1 = 1;
                if (resultado1 == 11)
                    resultado1 = 0;
                if (resultado2 == 10)
                    resultado2 = 1;
                if (resultado2 == 11)
                    resultado2 = 0;

                return String.Equals(resultado1.ToString(), dc1) && String.Equals(resultado2.ToString(), dc2);

            }
            catch (Exception)
            {
                return false;
            }
        }

        static long CalcularDC2(string cc, int[] numeros, int indiceMitadCC)
        {
            long dc2 = 0;

            for (int i = indiceMitadCC; i < cc.Length; i++)
            {
                dc2 += (int.Parse(cc[i].ToString()) * numeros[i]);
            }

            dc2 %= 11;
            dc2 = 11 - dc2;

            return dc2;
        }

        static long CalcularDC1(string cc, int[] numeros, int indiceMitadCC)
        {
            long dc1 = 0;

            for (int i = 0; i < indiceMitadCC; i++)
            {
                dc1 += (int.Parse(cc[i].ToString()) * numeros[i]);
            }

            dc1 %= 11;
            dc1 = 11 - dc1;

            return dc1;
        }
    }
}
