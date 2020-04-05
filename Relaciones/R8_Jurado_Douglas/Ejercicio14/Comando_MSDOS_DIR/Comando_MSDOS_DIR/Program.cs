/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS DIR.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using System.IO;

namespace Comando_MSDOS_DIR
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorioSeleccionado = Directory.GetCurrentDirectory();
            if (args.Length == 1)
                directorioSeleccionado += Path.DirectorySeparatorChar+ args[0];

            if (args.Length > 1)
            {
                Console.WriteLine("Error: porfavor introduce un solo directorio");
                return;
            }

            try
            {
                string[] directorios = Directory.GetDirectories(directorioSeleccionado).SkipWhile(x => File.GetAttributes(x) == FileAttributes.Hidden).ToArray();
                string[] ficheros = Directory.GetFiles(directorioSeleccionado).SkipWhile(x => File.GetAttributes(x) == FileAttributes.Hidden).ToArray();

                Console.WriteLine("\t Directorio de {0}", directorioSeleccionado);
                Console.WriteLine("\nFecha de la última modificación     Tipo\t Tamaño\t         Nombre");
                Console.WriteLine("----- -- -- ------ ------------     ----\t ------\t         ------");
                ListarDirectorios(directorios);
                ListarFicheros(ficheros);
                Console.WriteLine("\t\t\t\t\t {0} archivos {1,10:N} bytes", ficheros.Length, ficheros.Sum(x => new FileInfo(x).Length));
                Console.WriteLine("\t\t\t\t\t {0} directorios {1:N} bytes libres", directorios.Length, new DriveInfo(Path.GetPathRoot(directorioSeleccionado)).TotalFreeSpace);
            }
            catch
            {
                Console.WriteLine("\nError: Algo sucedio con el comando");
                return;
            }
        }

        private static void ListarFicheros(string[] ficheros)
        {
            foreach (string tmp in ficheros)
            {
                if(File.GetAttributes(tmp).HasFlag(FileAttributes.Archive))
                    Console.WriteLine("{0} {1,10}\t {2,15}\t {3:N}\t {4}", File.GetLastWriteTime(tmp).ToShortDateString(), File.GetLastWriteTime(tmp).ToShortTimeString(), "<FIL>", new FileInfo(tmp).Length.ToString().PadLeft(10), Path.GetFileName(tmp));
            }
        }

        private static void ListarDirectorios(string[] directorios)
        {
            foreach (string tmp in directorios)
            {
                if (File.GetAttributes(tmp).HasFlag(FileAttributes.Directory))
                    Console.WriteLine("{0,10} {1,10}\t {2,15}\t {3}\t {4}", Directory.GetLastWriteTime(tmp).ToShortDateString(), Directory.GetLastWriteTime(tmp).ToShortTimeString(), "<DIR>", " ".PadLeft(10), Path.GetFileName(tmp));
            }
        }
    }
}
