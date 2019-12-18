/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio6
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/12/2019						VERSION: 1.0
 * COMENTARIO: Función que dado un DNI calcula la letra del NIF.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formula DNI mod 23 nos da la posición de la letra de la cadena de letras "TRWAGMYFPDXBNJZSQVHLCKE"

            int dni = 0;
            char dc = ' ';

            Console.WriteLine("Esta aplicación cálcula la letra del NIF dado un DNI.");
            Console.WriteLine("".PadLeft(40,'-'));
            Console.Write("\n Dime el dni: ");
            try
            {
                dni = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            if (dni.ToString().Length != 8)
            {
                Console.WriteLine("Error: Algo ocurrio con el DNI introducido.");
                return;
            }

            dc = CalcularLetraNIF(dni);

            Console.WriteLine("\n El dígito de control es: {0}", dc);
            Console.Write(" El NIF queda de esta manera: {0}", dni);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(dc);
            Console.ResetColor();

            Console.ReadLine();
        }

        static char CalcularLetraNIF(int dni)
        {
            int mod = 23;
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";

            return letras[dni % mod];
        }
    }
}
