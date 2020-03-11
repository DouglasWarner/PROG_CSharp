/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 11/03/2020						VERSION: 1.0
 * COMENTARIO: Concatena el contenido de dos fichero, pasados por parametros, sobre el primer fichero.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------
using System.IO;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string primerFichero = string.Empty;
            string segundoFichero = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();

            // Si no existe vuelve a pedir los ficheros
            if (args.Length < 2)
            {
                Console.WriteLine("Porfavor introduce el primer fichero y segundo fichero, sin comillas.\n\n");

                Console.Write("Primer Fichero: ");
                primerFichero = Console.ReadLine();

                Console.Write("Segundo Fichero: ");
                segundoFichero = Console.ReadLine();

                // Si no lo ha introducido termina
                if (primerFichero.Length < 1 || segundoFichero.Length < 1)
                {
                    Console.WriteLine("Error: Algo ocurrio al introducir los nombres de los ficheros");
                    Console.ReadLine();
                    return;
                }
            }
            else                            // Si lo ha introducido los dos ficheros.
            {
                primerFichero = args[0];
                segundoFichero = args[1];
            }

            // Si no se ha especificado un directorio, se entiende que es de donde se llama el ejecutable.
            if (!Path.IsPathRooted(primerFichero))
                primerFichero = directorioActual + Path.DirectorySeparatorChar + primerFichero;
            if (!Path.IsPathRooted(segundoFichero))
                segundoFichero = directorioActual + Path.DirectorySeparatorChar + segundoFichero;

            if (!File.Exists(primerFichero))
            {
                Console.WriteLine("\nEl fichero no existe.");
                Console.ReadLine();
                return;
            }
            if (!File.Exists(segundoFichero))
            {
                Console.WriteLine("\nEl fichero no existe.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Primer Fichero: " + primerFichero);
            Console.WriteLine("Segundo Fichero: " + segundoFichero);

            ConcatenarFichero(primerFichero, segundoFichero);

            Console.Write("Eso es todo...");
            Console.ReadLine();
        }

        static void ConcatenarFichero(string pFichero, string sFichero)
        {
            using (StreamReader sr = new StreamReader(sFichero))
            using (StreamWriter sw = new StreamWriter(pFichero, true))
            {
                sw.Write(sw.NewLine);
                while (!sr.EndOfStream)
                {
                    sw.WriteLine(sr.ReadLine());
                }
            }


        }
    }
}
