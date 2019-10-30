using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------
using System.Threading;

namespace Ejemplo_30_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            char caracter = ' ';
            string frase = string.Empty;
            int pausa = 100;
            const int MIN = 1;
            int posDerecha = 1;
            bool direction = false;
            int MAX = Console.WindowWidth;

            //Console.Write("Pulsa una tecla: ");

           /*       EJEMPLO DE MOVER UNA FRASE DE IZQUIERDA A DERECHA
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.CursorVisible = false;

                    if (!direction)
                    {
                        Console.SetCursorPosition(posDerecha++, 10);
                        frase = " Voy a la derecha ";
                    }
                    else
                    {
                        Console.SetCursorPosition(posDerecha--, 10);
                        frase = " Voy a la izquierda ";
                    }

                    Console.Write(frase);

                    if (Console.CursorLeft > MAX - 5)
                        direction = true;
                    if (Console.CursorLeft - frase.Length == MIN)
                        direction = false;

                    if (tecla.Key == ConsoleKey.DownArrow)
                        pausa += 1;
                    if (tecla.Key == ConsoleKey.UpArrow)
                        pausa -= 1;

                    try
                    {
                        Thread.Sleep(pausa);
                    }
                    catch (Exception e)
                    {
                    }
                }

                tecla = Console.ReadKey();

            } while (tecla.Key != ConsoleKey.Escape);
            */

            /*          ALGORITMO PARA QUE SE HAGA ALGO HASTA PULSAR LA TECLA DESEADA
            caracter = (char)Console.Read();
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Write(caracter);
                    Thread.Sleep(pausa);
                }
                tecla = Console.ReadKey();

            }while(tecla.Key != ConsoleKey.Escape);
            */

            /*          COMPROBAR TECLAS PULSADAS CON LA CLASE CONSOLEKEYINFO
            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Z && tecla.Modifiers == ConsoleModifiers.Control)
            {
                Console.WriteLine("\n      Has pulsado la tecla.Key: {0}", tecla.Key);
                Console.WriteLine("    Has pulsado la tecla.KeyChar: {0}", tecla.KeyChar);
                Console.WriteLine("  Has pulsado la tecla.Modifiers: {0}", tecla.Modifiers);
            }
            else
            {
                Console.WriteLine("Porfavor intentalo de nuevo");
            }*/


            Console.ReadLine();
        }
    }
}
