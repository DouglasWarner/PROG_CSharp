/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio3
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 05/03/2020						VERSION: 1.0
 * COMENTARIO: Copia el contenido de un fichero a otro fichero, pasados por parametros.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheroOrigen = string.Empty;
            string ficheroDestino = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();

            // Si no existe vuelve a pedir los ficheros
            if (args.Length < 1)
            {
                Console.WriteLine("Porfavor introduce el fichero a copiar y el nombre del nuevo fichero, sin comillas.\n\nSi no se introduce, se creara con un nombre por defecto en el mismo directorio.\n");
                
                Console.Write("Fichero origen: ");
                ficheroOrigen = Console.ReadLine();

                Console.Write("Fichero destino: ");
                ficheroDestino = Console.ReadLine();
                
                // Si no lo ha introducido la copia termina
                if(ficheroOrigen.Length < 1 || ficheroDestino.Length < 1)
                {
                    Console.WriteLine("Error: Algo ocurrio al introducir los nombres de los ficheros");
                    Console.ReadLine();
                    return;
                }
            }
            else if (args.Length < 2)       // Si no introduce el fichero destino, se crea uno con el texto _copia
            {
                ficheroOrigen = args[0];
                ficheroDestino = Path.GetDirectoryName(args[0]) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(args[0]) + "_copia" + Path.GetExtension(args[0]);
            }
            else                            // Si lo ha introducido los dos ficheros, origin y destino.
            {
                ficheroOrigen = args[0];
                ficheroDestino = args[1];
            }

            // Si no se ha especificado un directorio, se entiende que es de donde se llama el ejecutable.
            if (!Path.IsPathRooted(ficheroOrigen))
                ficheroOrigen = directorioActual + Path.DirectorySeparatorChar + ficheroOrigen;
            if (!Path.IsPathRooted(ficheroDestino))
                ficheroDestino = directorioActual + Path.DirectorySeparatorChar + ficheroDestino;


            Console.WriteLine("Fichero a copiar: " + ficheroOrigen);
            Console.WriteLine("Fichero destino: " + ficheroDestino);
            
            Console.WriteLine("\n\nCopiando...");

            if (!File.Exists(ficheroOrigen))
            {
                Console.WriteLine("\nError: El fichero a copiar no existe...");
                Console.ReadLine();
                return;
            }

            // Si ya existe el fichero
            if (File.Exists(ficheroDestino))
            {
                Console.WriteLine("El fichero ya existe, quiere sobreescribirlo? s / n");
                // Si se quiere sobreescribir
                string tmp = Console.ReadLine()[0].ToString().ToUpper();
                if (tmp == "N")
                {
                    // Si no, se sale de la aplicación
                    Console.Write("Eso es todo, pulsa cualquier tecla...");
                    Console.ReadLine();
                    return;
                }
                else if(tmp == "S")
                    File.WriteAllLines(ficheroDestino, File.ReadAllLines(ficheroOrigen));
            }
            else
                File.WriteAllLines(ficheroDestino, File.ReadAllLines(ficheroOrigen));


            Console.Write("\nArchivo copiado con exito ");

            Console.ReadLine();

        }
    }
}
