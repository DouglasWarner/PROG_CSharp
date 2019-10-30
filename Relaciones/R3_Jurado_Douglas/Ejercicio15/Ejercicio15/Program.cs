/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio15
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Lee dos valores X e Y y muestra el mensaje VERDADERO 
 *             si X es mayor que Y y FALSO en otro caso.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class VerdaderoOFalso
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Esta aplicación comprueba si el valor X es mayor que el valor Y o viceversa.");
            Console.WriteLine("Muestra Verdadero si X es mayor que Y. Falso si Y es mayor.");
            Console.Write("Dime el valor de X: ");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Dime el valor de Y: ");
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(x > y)
                Console.WriteLine("Verdadero");
            else
                Console.WriteLine("Falso");

            Console.ReadLine();
        }
    }
}
