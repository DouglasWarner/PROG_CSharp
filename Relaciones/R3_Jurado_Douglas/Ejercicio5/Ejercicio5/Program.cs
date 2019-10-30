/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio5
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Un menú con opciones: Cálcular área de un cuadrado, un rectángulo y un triangulo.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class CalcularAreas
    {
        static void Main(string[] args)
        {
            string teclaPulsada = string.Empty;
            int posArr = 10;
            int posIzq = 5;

            do
            {
                Console.Clear();
                PintarMenu(posArr, posIzq);
                Console.CursorVisible = true;
                teclaPulsada = Console.ReadLine();

                switch (teclaPulsada)
                {
                    case "1":
                        Console.Clear();
                        CalcularAreaTriangulo();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        CalcularAreaCuadrado();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        CalcularAreaRectangulo();
                        Console.ReadLine();
                        break;
                    case "0":
                        
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MensajeError(posArr, posIzq, "Porfavor, selecciona una de las opciones.");
                        Console.CursorVisible = false;
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            } while (teclaPulsada != "0");

            Console.ReadLine();
        }


        static void PintarMenu(int posArr, int posIzq)
        {
            /*if (posArr >= Console.WindowHeight || posIzq >= Console.WindowWidth)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Superado los limites para pintar el menu");
                return;
            }*/

            Console.CursorTop = posArr;
            Console.CursorLeft = posIzq;

            Console.WriteLine("     Menu principal");
            Console.CursorLeft = posIzq;
            Console.WriteLine("".PadLeft(30,'─'));
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 1. Cálcular Área de un triangulo");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 2. Cálcular Área de un cuadrado");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 3. Cálcular Área de un rectángulo");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 0. Salir");
            Console.CursorLeft = posIzq;
            Console.Write("       Elige una opción: ");
        }

        static void MensajeError(int posArr, int posIzq, string mensaje)
        {
            Console.SetCursorPosition(posIzq + 45, posArr + 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
        }

        static void CalcularAreaTriangulo()
        {
            Console.WriteLine("Hola, voy a calcular el area de un triangulo");
        }

        static void CalcularAreaCuadrado()
        {
            Console.WriteLine("Hola, voy a calcular el area de un cuadrado");
        }

        static void CalcularAreaRectangulo()
        {
            Console.WriteLine("Hola, voy a calcular el area de un rectangulo");
        }
    }
}
