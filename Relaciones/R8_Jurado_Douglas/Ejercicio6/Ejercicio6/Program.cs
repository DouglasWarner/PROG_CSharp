/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio6
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 10/03/2020						VERSION: 1.0
 * COMENTARIO: Muestra el número de veces que sale un caracter en el archivo
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------
using System.IO;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string fichero = string.Empty;
            string caracter = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();

            if(args.Length < 2 && args.Length > 1 && args[0] == "help")
            {
                Console.WriteLine("\nMuestra el número de veces que sale un caracter en el archivo\n");
                Console.WriteLine("\n\tEjemplo: Ejercicio6 nombreFichero caracter\n");
                return;
            }

            // Si no existe vuelve a pedir los ficheros
            if (args.Length < 2)
            {
                Console.WriteLine("Error de formato\n");
                Console.WriteLine("Porfavor introduce el fichero y el caracter a contar.\n\n");
                Console.WriteLine("Ejemplo: Ejercicio6 nombreFichero caracter\n");

                Console.Write("Fichero: ");
                fichero = Console.ReadLine();

                Console.Write("Caracter: ");
                caracter = Console.ReadLine();

                // Si no lo ha introducido la copia termina
                if (fichero.Length < 1)
                {
                    Console.WriteLine("Error: Algo ocurrio al introducir el nombre del fichero o el caracter");
                    Console.ReadLine();
                    return;
                }
            }
            else                            // Si lo ha introducido los dos ficheros, origin y destino.
            {
                fichero = args[0];
                caracter = args[1];
            }

            if (!Path.IsPathRooted(fichero))
                fichero = directorioActual + Path.DirectorySeparatorChar + fichero;

            if (!File.Exists(fichero))
            {
                Console.Write("\nError: El fichero no existe...");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(" Contenido del fichero");
            Console.WriteLine("-------------------------\n");

            int v = NVecesCaracter(fichero, caracter);

            Console.WriteLine("\nEl caracter {0} aparece {1} veces", caracter, v);

            Console.Write("\nEso es todo, pulsa cualquier boton... ");
            Console.ReadLine();
        }

        static int NVecesCaracter(string fichero, string caracter)
        {
            int nVeces = 0;
            char caracterLeido;

            using (FileStream fs = new FileStream(fichero, FileMode.Open, FileAccess.Read))
            {
                while(fs.Position < fs.Length)
                {
                    caracterLeido = (char)fs.ReadByte();

                    if(caracterLeido.ToString() == caracter)
                    {
                        nVeces++;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(caracterLeido);

                    Console.ResetColor();
                }
            }

            return nVeces;
        }

        static int NVecesCaracterSinFlujo(string fichero, string caracter)
        {
            int nveces = 0;

            foreach (var item in File.ReadAllLines(fichero))
            {
                nveces += item.Count(x => x == char.Parse(caracter));
            }

            return nveces;
        }
    }
}
