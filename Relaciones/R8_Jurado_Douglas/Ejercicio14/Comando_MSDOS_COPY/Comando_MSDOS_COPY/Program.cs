/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS COPY.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;

namespace Comando_MSDOS_COPY
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;

            string[] ficherosOrigen = args.Take(args.Length - 1).ToArray();
            string destino = args[args.Length - 1];

            if (!Path.IsPathRooted(args[args.Length - 1]))
            {
                ficherosOrigen = args;
                destino = Directory.GetCurrentDirectory();
            }

            if (Directory.Exists(destino))
                Copiar(ficherosOrigen, destino);
        }

        static void Copiar(string[] ficheros, string destino)
        {
            int nCopiados = 0;

            foreach (string item in ficheros)
            {
                try
                {
                    if (!File.Exists(item))
                        continue;

                    File.Copy(item, destino + Path.DirectorySeparatorChar + Path.GetFileName(item));
                    nCopiados++;
                }
                catch
                {
                    Console.WriteLine("\nNo se puede copiar el archivo {0} sobre si mismo.", item);
                }
            }

            Console.WriteLine("\tArchivo(s) copiado(s): {0}", nCopiados);
        }
    }
}

