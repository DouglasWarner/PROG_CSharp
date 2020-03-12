/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio11
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 11/03/2020						VERSION: 1.0
 * COMENTARIO: Lee lineas desde el teclado y las guarda en un fichero.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea = string.Empty;
            StringBuilder contenido = new StringBuilder();
            string ruta = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "texto.txt";

            Console.WriteLine("\nEscribe hasta introducir una línea vacía");

            #region Primera Forma
            do
             {
                 linea = Console.ReadLine();
                 contenido.AppendLine(linea);
             } while (linea != string.Empty);

            InsertarContenido(ruta, contenido.ToString());
            #endregion

            /*
            #region Segunda Forma
            InsertarContenido(ruta);
            #endregion
            */

            Console.WriteLine("\nContenido insertado");
            Console.WriteLine("".PadLeft(100,'-'));

            MostrarContenido(ruta);

            Console.ReadLine();
        }

        static bool InsertarContenido(string fichero, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fichero))
                {
                    sw.Write(contenido);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        // Otra forma de insertar lineas escritas por consola
        static bool InsertarContenido(string fichero)
        {
            TextWriter tmp = Console.Out;
            string linea = string.Empty;
    
            try
            {
                using (StreamWriter sw = new StreamWriter(fichero))
                {
                    Console.SetOut(sw);

                    do
                    {
                        linea = Console.ReadLine();
                        Console.WriteLine(linea);
                    } while (linea != string.Empty);

                    Console.SetOut(tmp);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        static bool MostrarContenido(string fichero)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }
    }
}
