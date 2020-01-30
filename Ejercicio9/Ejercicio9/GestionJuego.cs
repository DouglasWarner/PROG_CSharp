using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class GestionJuego
    {
        private Random rnd = new Random();
        private int anchura = Console.WindowWidth-2;
        private int altura = Console.WindowHeight-4;
        private int movimientoTesoro;
        private bool encontrado;
        private string[] mensajeFin;
        private string[,] areaJuego;
        private Jugador j;
        private Tesoro t;

        public GestionJuego()
        {
            j = new Jugador(rnd.Next(2,anchura), rnd.Next(2,altura));
            t = new Tesoro(rnd.Next(2,anchura), rnd.Next(2,altura));

            mensajeFin = new string[] {"".PadRight(anchura/2,'*'),
                                       "".PadRight(anchura/2,'*'),
                                       "**                                                       **",
                                       "**                   G A N A S T E S                     **",
                                       "**                                                       **",
                                       "".PadRight(anchura/2,'*'),
                                       "".PadRight(anchura/2,'*')};
            encontrado = false;
        }

        private string[,] CrearArea()
        {
            areaJuego = new string[altura, anchura];

            for (int i = 0; i < areaJuego.GetLength(0); i++)
            {
                for (int k = 0; k < areaJuego.GetLength(1); k++)
                {
                    areaJuego[0, k] = "*";
                    areaJuego[i,0] = "*";
                }
            }

            return areaJuego;
        }

        private void PintarArea()
        {
            Console.WriteLine("\tJUGADOR:  X: {0}, Y: {1}     TESORO:  X: {2}, Y: {3} \t\t\t\t\tESCAPE PARA SALIR", j.PosX, j.PosY, t.PosX, t.PosY);

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < areaJuego.GetLength(0); i++)
            {
                for (int k = 0; k < areaJuego.GetLength(1); k++)
                {
                    Console.Write(areaJuego[i,k]);
                }
                Console.WriteLine();
            }   
            Console.ResetColor();

            PintarJugador();
            PintarTesoro();
        }

        private void MostrarMensajeFin()
        {
            Console.CursorTop = 10;
            Console.CursorLeft = 30;
            for (int i = 0; i < mensajeFin.Length; i++)
            {
                Console.CursorLeft = 30;
                Console.WriteLine(mensajeFin[i]);
            }
        }

        private void PintarJugador()
        {
            Console.CursorLeft = j.PosX;
            Console.CursorTop = j.PosY;
            Console.Write(j.Icono);
        }

        private void PintarTesoro()
        {
            Console.CursorLeft = t.PosX;
            Console.CursorTop = t.PosY;
            Console.Write(t.Icono);
        }

        private void MovimientoJugador(ConsoleKey tecla)
        {
            if (tecla == ConsoleKey.UpArrow)
                j.PosY++;
            if (tecla == ConsoleKey.DownArrow)
                j.PosY--;
            if (tecla == ConsoleKey.RightArrow)
                j.PosX++;
            if (tecla == ConsoleKey.LeftArrow)
                j.PosX--;
        }
        private void MovimientoTesoro()
        {
            

            movimientoTesoro = rnd.Next(4);

        }

        public void Jugar()
        {
            ConsoleKeyInfo movimiento = new ConsoleKeyInfo();

            CrearArea();

            do
            {
                PintarArea();
                PintarJugador();
                PintarTesoro();

            } while ((movimiento = Console.ReadKey()).Key != ConsoleKey.Escape);
        }

        
    }
}
