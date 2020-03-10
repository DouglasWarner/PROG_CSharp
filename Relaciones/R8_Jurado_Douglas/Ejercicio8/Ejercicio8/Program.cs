/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 10/03/2020						VERSION: 1.0
 * COMENTARIO: Consta de dos funciones, uno que crea un fichero con la lista de alumnos y otro que lista el fichero por consola.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------
using System.IO;

namespace Ejercicio8
{
    class Program
    {
        static Dictionary<string, string[]> listaAlumnos = new Dictionary<string, string[]>();

        static void Main(string[] args)
        {
            CrearListaAlumnos();
            
            if (args.Length < 2 && args.Length > 1 && args[0] == "help")
            {
                Console.WriteLine("\nConsta de dos funciones, uno que crea un fichero con la lista de alumnos y otro que lista el fichero por consola.\n");
                Console.WriteLine("\n\tEjemplo: Ejercicio8\n");
                return;
            }
            
            Menu();

            Console.Write("\nEso es todo, pulsa cualquier boton... ");
            Console.ReadLine();
        }

        static void Menu()
        {
            string opcion = string.Empty;
            
            do
            {
                Console.WriteLine(" 1. Crear fichero");
                Console.WriteLine(" 2. Listar fichero");
                Console.WriteLine("\n\ts. Salir");
                Console.Write("\nElige una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre del fichero que se va a crear: ");

                        try
                        {
                            CrearFichero(Console.ReadLine());
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }

                        break;
                    case "2":
                        Console.Write("Nombre del fichero a leer: ");
                        string tmpFichero = Console.ReadLine();

                        Console.WriteLine(" Contenido del fichero");
                        Console.WriteLine("-------------------------\n");

                        try
                        {
                            ListarFichero(tmpFichero);
                        }
                        catch(IOException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }

                        break;
                    default:
                        break;
                }

                Console.Clear();

            } while (opcion != "s");
        }

        static void CrearListaAlumnos()
        {
            listaAlumnos.Add("111", new string[] { "Douglas", "Jurado" } );
            listaAlumnos.Add("222", new string[] { "Pepe", "Maiz" });
            listaAlumnos.Add("333", new string[] { "Bocadillo", "DeAtun" });
        }

        static void CrearFichero(string nombreFichero)
        {
            if (!Path.IsPathRooted(nombreFichero))
                nombreFichero = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + nombreFichero;

            if (File.Exists(nombreFichero))
            {
                Console.Write("\nEl fichero ya existe");
                Console.ReadLine();
                return;
            }

            using (FileStream fs = new FileStream(nombreFichero, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(string.Format("Codigo\t   Nombre\t   Apellido\n{0}", "".PadLeft(100, '-')));

                foreach (var item in listaAlumnos)
                {
                    sw.WriteLine(string.Format("[{0}]\t{1}\t{2}", item.Key, item.Value[0].PadLeft(10), item.Value[1].PadLeft(10)));
                }

                Console.WriteLine("Fichero creado con exito");
            }
        }

        static void ListarFichero(string nombreFichero)
        {
            if (!Path.IsPathRooted(nombreFichero))
                nombreFichero = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + nombreFichero;

            if (!File.Exists(nombreFichero))
            {
                Console.Write("\nError: El fichero no existe...");
                Console.ReadLine();
                return;
            }

            using (FileStream fs = new FileStream(nombreFichero, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadToEnd());

                Console.WriteLine("Eso es todo");
                Console.ReadLine();
            }
        }
    }
}
