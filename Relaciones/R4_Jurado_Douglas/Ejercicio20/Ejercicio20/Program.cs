/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio20
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Pinta por pantalla un árbol.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;
            bool pinta = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Esta aplicación pinta por pantalla un árbol, con una altura de entre 5 y 30.");
                Console.Write("Dime la altura del árbol entre 5 y 30:  ");

                try
                {
                    altura = int.Parse(Console.ReadLine());
                    if (altura >= 5 && altura <= 30)
                        pinta = true;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Porfavor introduce una altura entre 5 y 30");
                        Console.ReadLine();
                        Console.ResetColor();
                    }

                    if (pinta)
                        PintaArbol(altura);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    Console.ResetColor();
                }
            } while (!pinta);

            Console.ReadLine();
        }

        static void PintaArbol(int altura)
        {
            int posArriba = Console.WindowHeight / 4;
            int posIzquierda = Console.WindowWidth / 2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorTop = posArriba;
            for (int i = 0; i < altura; i++)
            {
                Console.CursorLeft = posIzquierda;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                
                Console.WriteLine();
            }

            Console.CursorTop = posArriba;
            for (int i = 0; i < altura; i++)
            {
                Console.CursorLeft = posIzquierda--;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                
                Console.WriteLine();
            }
            Console.ResetColor();

            if (altura > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.CursorLeft = posIzquierda + (altura - 2);
                Console.WriteLine("*****");
                Console.CursorLeft = posIzquierda + (altura - 2);
                Console.WriteLine("*****");
                Console.CursorLeft = posIzquierda + (altura - 2);
                Console.WriteLine("*****");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.CursorLeft = posIzquierda + (altura - 1);
                Console.WriteLine("***");
                Console.CursorLeft = posIzquierda + (altura - 1);
                Console.WriteLine("***");
                Console.CursorLeft = posIzquierda + (altura - 1);
                Console.WriteLine("***");
                Console.ResetColor();
            }
        }
    }
}
