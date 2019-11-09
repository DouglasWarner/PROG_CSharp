/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio21
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Muestra un menú con sus opciones. 0 para salir.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int posArb = 10;
            int posIzq = 60;
            bool salir = false;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            Console.WriteLine("Esta aplicación muestra un menú.\n");

            do
            {
                Console.Clear();
                PintaMenu();

                tecla = Console.ReadKey();
                Console.ReadLine();

                switch (tecla.KeyChar)
                {
                    case '1':
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.Write("Altas");
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.Write("Bajas");
                        Console.ReadLine();
                        break;
                    case '3':
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.Write("Modificaciones");
                        Console.ReadLine();
                        break;
                    case '4':
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.Write("Consultas");
                        Console.ReadLine();
                        break;
                    case '0':
                        Console.Write("¿Seguro que quieres salir? S / N ");
                        tecla = Console.ReadKey();
                        if (tecla.Key == ConsoleKey.S)
                            salir = true;
                        break;
                    default:
                        break;
                }

            } while(!salir);

            Console.ReadLine();
        }

        static void PintaMenu()
        {
            int posArriba = 5;
            int posIzquierda = 5;

            Console.CursorLeft = posIzquierda;
            Console.CursorTop = posArriba;

            Console.WriteLine("".PadLeft(30,'='));
            Console.CursorLeft = posIzquierda;
            Console.WriteLine("       MENU PRINCIPAL ");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine("".PadLeft(30, '='));
            Console.CursorLeft = posIzquierda;
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 1.  Altas");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 2.  Bajas");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 3.  Modificaciones");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 4.  Consultas");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 0.  Salir");
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.Write(" Porfavor, pulsa una opción: ");
        }
    }
}
