/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio4
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 05/03/2020						VERSION: 1.0
 * COMENTARIO: Copia el contenido de un fichero a otro fichero, sin el caracter pasado desde linea de parametros.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------
using System.IO;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheroOrigen = string.Empty;
            string ficheroDestino = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();
            string caracter = string.Empty;

            // Si no existe vuelve a pedir los ficheros
            if (args.Length < 3)
            {
                Console.WriteLine("Error de formato\n");
                Console.WriteLine("Porfavor introduce el fichero a copiar y el nombre del nuevo fichero y el caracter que no se copiará, sin comillas.\n\n");
                Console.WriteLine("Ejemplo: Ejercicio4 ficheroDestino ficheroFuente caracter\n");

                Console.Write("Fichero origen: ");
                ficheroOrigen = Console.ReadLine();

                Console.Write("Fichero destino: ");
                ficheroDestino = Console.ReadLine();

                Console.Write("Caracter: ");
                caracter = Console.ReadLine();

                // Si no lo ha introducido la copia termina
                if (ficheroOrigen.Length < 1 || ficheroDestino.Length < 1 || caracter.Length < 1)
                {
                    Console.WriteLine("Error: Algo ocurrio al introducir los nombres de los ficheros o el caracter");
                    Console.ReadLine();
                    return;
                }
            }
            else                            // Si lo ha introducido los dos ficheros, origin y destino.
            {
                ficheroOrigen = args[1];
                ficheroDestino = args[0];
                caracter = args[2];
            }

            // Si no se ha especificado un directorio, se entiende que es de donde se llama el ejecutable.
            if (!Path.IsPathRooted(ficheroOrigen))
                ficheroOrigen = directorioActual + Path.DirectorySeparatorChar + ficheroOrigen;
            if (!Path.IsPathRooted(ficheroDestino))
                ficheroDestino = directorioActual + Path.DirectorySeparatorChar + ficheroDestino;


            Console.WriteLine("Fichero fuente: " + ficheroOrigen);
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
                else if (tmp == "S")
                {
                    try
                    {
                        CopiarContenidoAFichero(ficheroOrigen, ficheroDestino, caracter);
                    }
                    catch(IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else
            {
                try
                {
                    CopiarContenidoAFichero(ficheroOrigen, ficheroDestino, caracter);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }

        static void CopiarContenidoAFichero(string ficheroFuente, string ficheroDestino, string caracter)
        {
            using (StreamReader sr = new StreamReader(ficheroFuente))
            using (StreamWriter sw = new StreamWriter(ficheroDestino))
            {
                string item = string.Empty;

                while ((item = sr.ReadLine()) != null)
                {
                    sw.WriteLine(item.Where(x => x != char.Parse(caracter)).ToArray());
                }
            }

            Console.Write("\nArchivo copiado con exito ");
        }
    }
}
