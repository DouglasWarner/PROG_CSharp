/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio5
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 10/03/2020						VERSION: 1.0
 * COMENTARIO: Muestra el contenido de un fichero pasado por parametro.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------
using System.IO;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fichero = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();
            string[] contenido;

            // Si no existe vuelve a pedir los ficheros
            if (args.Length < 1)
            {
                Console.WriteLine("Error de formato\n");
                Console.WriteLine("Porfavor introduce el fichero a mostrar.\n\n");
                Console.WriteLine("Ejemplo: Ejercicio5 \n");

                Console.Write("Fichero: ");
                fichero = Console.ReadLine();

                // Si no lo ha introducido la copia termina
                if (fichero.Length < 1)
                {
                    Console.WriteLine("Error: Algo ocurrio al introducir el nombre del fichero");
                    Console.ReadLine();
                    return;
                }
            }
            else                            // Si lo ha introducido los dos ficheros, origin y destino.
            {
                fichero = args[0];
            }

            if (!Path.IsPathRooted(fichero))
                fichero = directorioActual + Path.DirectorySeparatorChar + fichero;

            if(!File.Exists(fichero))
            {
                Console.Write("\nError: El fichero no existe...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(" Contenido del fichero");
            Console.WriteLine("-------------------------\n");

            contenido = File.ReadAllLines(fichero);

            for (int i = 0; i < contenido.Length; i++)
            {
                Console.WriteLine("\t"+contenido[i]);
            }

            Console.Write("\nEso es todo, pulsa cualquier boton... ");
            Console.ReadLine();
        }
    }
}
