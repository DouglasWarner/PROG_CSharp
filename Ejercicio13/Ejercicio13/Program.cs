using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio13
{
    class Program
    {
        static int maxAncho = Console.WindowWidth - 5;
        static int maxAlto = Console.WindowHeight - 5;

        static void Main(string[] args)
        {
            int pausa = 50;
            int generaciones = 0;
            int[,] tablero = new int[maxAlto, maxAncho];
            ConsoleKeyInfo opcion = new ConsoleKeyInfo();
            string mensaje = String.Format("Juego de la vida     Avanzar generación:  i     Automatico:  a     Reiniciar:  r     Guardar:  s     Cargar:  l     ESC:  Salir    ");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.CursorVisible = false;
            Console.Title = mensaje;

            InicializaTabla(tablero);
            PintarTablero(tablero);

            while (!Console.KeyAvailable)
            {
                opcion = Console.ReadKey(true);

                switch (opcion.KeyChar)
                {
                    case 'i':
                        AvanzarGeneracion(tablero);
                        Console.Title = mensaje + generaciones++;
                        break;
                    case 'a':
                        AvanzarAutomatico(pausa, ref generaciones, tablero, mensaje);
                        break;
                    case 'r':
                        InicializaTabla(tablero);
                        PintarTablero(tablero);
                        Console.Title = mensaje + generaciones++;
                        break;
                    case 's':
                        Console.Title = "Salvado";
                        break;
                    case 'l':
                        Console.Title = "Leido";
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }

        static void AvanzarAutomatico(int pausa, ref int generaciones, int[,] tablero, string mensaje)
        {
            while (!Console.KeyAvailable)
            {
                tablero = NuevaGeneracion(tablero);
                PintarTablero(tablero);
                Console.Title = mensaje + generaciones++;
                Thread.Sleep(pausa);
            }
        }

        static void AvanzarGeneracion(int[,] tablero)
        {
            tablero = NuevaGeneracion(tablero);
            PintarTablero(tablero);
        }

        static void PintarTablero(int[,] tabla)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < maxAlto; i++)
            {
                for (int j = 0; j < maxAncho; j++)
                {
                    if (tabla[i, j] == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static bool InicializaTabla(int[,] tabla)
        {
            Random rnd = new Random();
            int valores = 2;

            for (int i = 0; i < maxAlto; i++)
                for (int j = 0; j < maxAncho; j++)
                    tabla[i, j] = rnd.Next(valores);

            return true;
        }

        static int GetCeldasVivas(int[,] tabla, int posI, int posJ)
        {
            int celdasVivas = tabla[posI, (posJ + 1) % maxAncho] + 
                              tabla[posI, ((posJ - 1)+maxAncho) % maxAncho] +
                              tabla[(posI + 1) % maxAlto, (posJ + 1) % maxAncho] + 
                              tabla[((posI - 1)+maxAlto) % maxAlto, ((posJ - 1)+maxAncho) % maxAncho] +
                              tabla[(posI + 1) % maxAlto, posJ] +
                              tabla[((posI - 1) + maxAlto) % maxAlto, posJ] + 
                              tabla[(posI + 1) % maxAlto, ((posJ - 1)+maxAncho) % maxAncho] +
                              tabla[((posI - 1) + maxAlto) % maxAlto, (posJ + 1) % maxAncho];

            return celdasVivas;
        }

        /*  1. Si una celdilla está viva y tiene 2 o 3 vecinas permanece viva.
            2. Si una celdilla está viva y tiene menos de 2 vecinas muere de soledad.
            3. Si una celdilla está viva y tiene mas de 3 vecinas muere por sobrecarga de población.
            4. Si una celdilla está muerta y tiene exactamente 3 vecinas entonces pasa a estar viva (nace).
         * */
        static int[,] NuevaGeneracion(int[,] tabla)
        {
            int[,] generacion = new int[maxAlto, maxAncho];

            for (int i = 0; i < maxAlto; i++)
            {
                for (int j = 0; j < maxAncho; j++)
                {
                    if (tabla[i, j] == 1 && (GetCeldasVivas(tabla, i, j) < 2 || GetCeldasVivas(tabla, i, j) > 3))
                        generacion[i, j] = 0;
                    if (tabla[i, j] == 0 && GetCeldasVivas(tabla, i, j) == 3)
                        generacion[i, j] = 1;
                    if (tabla[i, j] == 1 && (GetCeldasVivas(tabla, i, j) == 2 || GetCeldasVivas(tabla, i, j) == 3))
                        generacion[i,j] = 1;
                }
            }

            return generacion;
        }
    }
}
