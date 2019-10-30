/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Lee por teclado un número secreto y el otro compañero tiene que acertarlo, 
 *              alfinal se mostrar en número de intentos.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class AcertarNumero
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool acertaste = false;
            string tmp = string.Empty;
            int nIntentos = 0;

            Console.WriteLine("Juego de acertar el número del otro.");
            Console.WriteLine("Dime el número que tiene que acertar entre 0 y 100.");
            Console.ForegroundColor = ConsoleColor.Black;
            tmp = Console.ReadLine();
            Console.ResetColor();
            if (!int.TryParse(tmp, out numero1))
            {
                Console.WriteLine("Porfavor introduce un número.");
                Console.ReadLine();
                return;
            }
            if(numero1 > 100 || numero1 < 0)
            {
                Console.WriteLine("Porfavor, introduce un número entre 0 y 100");
                Console.ReadLine();
                return;
            }
            
            do
            {
                tmp = Console.ReadLine();
                
                if (!int.TryParse(tmp, out numero2))
                {
                    Console.WriteLine("Porfavor introduce un número.");
                    Console.ReadLine();
                }
                
                nIntentos++;
                if (numero1 == numero2)
                {
                    acertaste = true;
                    Console.WriteLine("Enhorabuena. ACERTASTE en {0} intentos.", nIntentos);
                    Console.ReadLine();
                }
                

            } while (!acertaste);
        }
    }
}
