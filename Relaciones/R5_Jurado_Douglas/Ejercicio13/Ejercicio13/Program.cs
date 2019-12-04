/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 01/12/2019						VERSION: 1.0
 * COMENTARIO: Simula el Juego de la Vida de John Horton Conway. Pudiendo guardar y cargar una generación por fichero.
 *---------------------------------------------------------------------- */

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
        static int generaciones = 0;
        static string mensaje = String.Format("Juego de la vida     Avanzar generación:  i     Automatico:  a     Reiniciar:  r     Guardar:  s     Cargar:  l     ESC:  Salir    ");

        static void Main(string[] args)
        {
            int pausa = 50;
            int[,] tablero = new int[maxAlto, maxAncho];
            ConsoleKeyInfo opcion = new ConsoleKeyInfo();
            
            InicializaTabla(tablero);
            PintarTablero(tablero);

            while (!Console.KeyAvailable)
            {
                Console.Title = mensaje + " Generaciones: " + generaciones;
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
                        tablero = AvanzarAutomatico(pausa, tablero);
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

        #region Mis Metodos
        
        /// <summary>
        /// Avanza automaticamente el ciclo de vida.
        /// </summary>
        /// <param name="pausa">Velocidad en la que avanza</param>
        /// <param name="tablero">Tablero con el ciclo de vida</param>
        /// <returns>Devuelve un tablero nuevo con la siguiente generación</returns>
        static int[,] AvanzarAutomatico(int pausa, int[,] tablero)
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

        /// <summary>
        /// Muestra el tablero del juego de la vida
        /// </summary>
        /// <param name="tablero">Tablero a mostrar por pantalla.</param>
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

        /// <summary>
        /// Inicializa automaticamente entre 1 y 0 la primero generación de vida.
        /// </summary>
        /// <param name="tabla">Matriz a iniciar</param>
        /// <returns>Devuelve true</returns>
        static bool InicializaTabla(int[,] tabla)
        {
            Random rnd = new Random();
            int valores = 2;

            for (int i = 0; i < maxAlto; i++)
                for (int j = 0; j < maxAncho; j++)
                    tabla[i, j] = rnd.Next(valores);

            return true;
        }

        /// <summary>
        /// Obtiene la cantidad de celdas vivas de alrededor.
        /// </summary>
        /// <param name="tabla">Tablero</param>
        /// <param name="posI">Posicion actual de la matriz en i de la celda</param>
        /// <param name="posJ">Posicion actual de la matriz en j de la celda</param>
        /// <returns>Devuelve el total de celdas vivas</returns>
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

        /// <summary>
        /// Avanza de generación.
        /// </summary>
        /// <param name="tablero">Tablero</param>
        /// <returns>Devuelve una matriz con una nueva generación</returns>
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

        /// <summary>
        /// Guarda la generación actual en un fichero de texto
        /// </summary>
        /// <param name="tablero">Tablero matriz 2D</param>
        /// <returns>Devuelve True si se ha completado, False si no existe el fichero.</returns>
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
                sw.WriteLine("Generacion: " + generaciones);

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

        /// <summary>
        /// Carga la generación desde un fichero de texto.
        /// </summary>
        /// <param name="tablero">Tablero matriz 2D</param>
        /// <returns>Devuelve True si se ha cargado, False si el fichero no existe.</returns>
        static bool Leer(int[,] tablero)
        {
            string nombreFichero = string.Empty;
            string fichero = string.Empty;
            string lineaLeida = string.Empty;
            int indice = 0;     // Indice i para recorrer las posiciones de i en la matriz 2D.
            string[] generacion;
            bool hayGeneracion = false;

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
                    // Obtiene las generaciones por las que iban, si es que tenia generaciones.
                    generacion = lineaLeida.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (!hayGeneracion && generacion.Length > 1)
                    {
                        generaciones = int.Parse(generacion[1]);
                        hayGeneracion = true;
                    }
                    else
                    {
                        for (int j = 0; j < lineaLeida.Length; j++)
                        {
                            tablero[indice, j] = lineaLeida[j] == '*' ? 1 : 0;
                        }

                        indice++;   // Paso a la siguiente posicion en i de la matriz 2D.
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("\n\n     Leido");
            return true;
        }

        #endregion
    }
}

