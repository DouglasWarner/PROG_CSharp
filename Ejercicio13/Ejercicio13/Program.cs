using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

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
            
            Console.Title = mensaje + " Generaciones: " + generaciones;

            InicializaTabla(tablero);
            PintarTablero(tablero);

            while (!Console.KeyAvailable)
            {
                PintarTablero(tablero);
                opcion = Console.ReadKey(true);

                switch (opcion.KeyChar)
                {
                    case 'i':
                        tablero = NuevaGeneracion(tablero);
                        PintarTablero(tablero);
                        Console.Title = mensaje + " Generaciones: " + ++generaciones;
                        break;
                    case 'a':
                        tablero = AvanzarAutomatico(pausa, ref generaciones, tablero, mensaje);
                        Console.ReadKey(true);
                        break;
                    case 'r':
                        InicializaTabla(tablero);
                        PintarTablero(tablero);
                        generaciones = 0;
                        Console.Title = mensaje + " Generaciones: " + generaciones;
                        break;
                    case 's':
                        Salvar(tablero);

                        Console.ReadLine();
                        break;
                    case 'l':
                        if(!Leer(tablero))
                            Console.WriteLine("Error: el fichero no existe.");

                        Console.ReadLine();
                        break;
                    case (char)ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }

        static int[,] AvanzarAutomatico(int pausa, ref int generaciones, int[,] tablero, string mensaje)
        {
            while (!Console.KeyAvailable)
            {
                tablero = NuevaGeneracion(tablero);
                PintarTablero(tablero);
                Console.Title = mensaje + " Generaciones: " + ++generaciones;
                Thread.Sleep(pausa);
            }
            
            return tablero;
        }

        static void PintarTablero(int[,] tablero)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < maxAlto; i++)
            {
                for (int j = 0; j < maxAncho; j++)
                {
                    if (tablero[i, j] == 1)
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
                              tabla[posI, ((posJ - 1) + maxAncho) % maxAncho] +
                              tabla[(posI + 1) % maxAlto, (posJ + 1) % maxAncho] +
                              tabla[((posI - 1) + maxAlto) % maxAlto, ((posJ - 1) + maxAncho) % maxAncho] +
                              tabla[(posI + 1) % maxAlto, posJ] +
                              tabla[((posI - 1) + maxAlto) % maxAlto, posJ] +
                              tabla[(posI + 1) % maxAlto, ((posJ - 1) + maxAncho) % maxAncho] +
                              tabla[((posI - 1) + maxAlto) % maxAlto, (posJ + 1) % maxAncho];

            return celdasVivas;
        }

        /*  1. Si una celdilla está viva y tiene 2 o 3 vecinas permanece viva.
            2. Si una celdilla está viva y tiene menos de 2 vecinas muere de soledad.
            3. Si una celdilla está viva y tiene mas de 3 vecinas muere por sobrecarga de población.
            4. Si una celdilla está muerta y tiene exactamente 3 vecinas entonces pasa a estar viva (nace).
         * */
        static int[,] NuevaGeneracion(int[,] tablero)
        {
            int[,] generacion = new int[maxAlto, maxAncho];
            int celdasVivas = 0;

            for (int i = 0; i < maxAlto; i++)
            {
                for (int j = 0; j < maxAncho; j++)
                {
                    celdasVivas = GetCeldasVivas(tablero, i, j);

                    if (tablero[i, j] == 1 && (celdasVivas < 2 || celdasVivas > 3))
                        generacion[i, j] = 0;
                    if (tablero[i, j] == 0 && celdasVivas == 3)
                        generacion[i, j] = 1;
                    if (tablero[i, j] == 1 && (celdasVivas == 2 || celdasVivas == 3))
                        generacion[i, j] = 1;
                }
            }

            return generacion;
        }

        static bool Salvar(int[,] tablero)
        {
            string nombreFichero = string.Empty;
            string fichero = string.Empty;

            Console.SetCursorPosition(0, maxAlto + 3);
            Console.ResetColor();
            Console.CursorVisible = true;

            Console.WriteLine("Salvando...");
            Console.Write("Dime el nombre del fichero: ");
            nombreFichero = Console.ReadLine();

            if (nombreFichero == "")
            {
                Console.WriteLine("Error: El nombre de fichero vacio.");
                return false;
            }

            fichero = Directory.GetCurrentDirectory() + "/" + nombreFichero + ".txt";

            using (StreamWriter sw = new StreamWriter(fichero))
            {
                for (int i = 0; i < maxAlto; i++)
                {
                    for (int j = 0; j < maxAncho; j++)
                    {
                        sw.Write(tablero[i, j] == 1 ? "*" : " ");
                    }
                    sw.WriteLine();
                }
            }

            Console.Clear();
            Console.WriteLine("\n\n     Salvado");
            return true;
        }

        static bool Leer(int[,] tablero)
        {
            string nombreFichero = string.Empty;
            string fichero = string.Empty;
            string lineaLeida = string.Empty;
            int indice = 0;     // Indice i para recorrer las posiciones de i en la matriz 2D.

            Console.SetCursorPosition(0, maxAlto + 3);
            Console.ResetColor();
            Console.CursorVisible = true;

            Console.WriteLine("Cargando...");
            Console.Write("Dime el nombre del fichero: ");
            nombreFichero = Console.ReadLine();

            if (nombreFichero == "")
                return false;

            fichero = Directory.GetCurrentDirectory() + "/" + nombreFichero;

            if (!File.Exists(fichero))
                return false;

            using (StreamReader sr = new StreamReader(fichero))
            {
                while((lineaLeida = sr.ReadLine()) != null)
                {
                    for (int j = 0; j < lineaLeida.Length; j++)
                    {
                        tablero[indice, j] = lineaLeida[j] == '*' ? 1 : 0;
                    }

                    indice++;   // Paso a la siguiente posicion en i de la matriz 2D.
                    lineaLeida = string.Empty;
                }
            }

            Console.Clear();
            Console.WriteLine("\n\n     Leido");
            return true;
        }
    }
}

