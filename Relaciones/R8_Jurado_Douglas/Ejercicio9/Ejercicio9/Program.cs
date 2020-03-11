/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio9
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 11/03/2020						VERSION: 1.0
 * COMENTARIO: Muestra todos los fichero pasados por argumentos.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using System.IO;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ficheros = null;

            if (args.Length < 1)
            {
                Console.WriteLine("\nError al pasar los ficheros");

                Console.WriteLine("\n Ejemplo: Ejercicio9 fichero1 [fichero2 fichero3 ...]");
                Console.ReadLine();
                return;
            }
            else
                ficheros = args;


            for (int i = 0; i < ficheros.Length; i++)
            {
                Console.WriteLine("\n\tFichero: {0}", Path.GetFileName(ficheros[i]));
                Console.WriteLine("".PadLeft(100,'-'));
                MostrarContenido(ficheros[i]);
            }

            Console.Write("\nEso es todo...");
            Console.ReadLine();
            
        }

        static void MostrarContenido(string fichero)
        {
            if (!File.Exists(fichero))
                return;

            using (StreamReader sr = new StreamReader(fichero))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
