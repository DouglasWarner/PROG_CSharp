/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS TYPE.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;

namespace Comando_MSDOS_TYPE
{
    class Program
    {
        static void Main(string[] args)
        {
            string fichero = string.Empty;
            string directorioActual = Directory.GetCurrentDirectory();

            if (args.Length < 1)
                return;

            for (int i = 0; i < args.Length; i++)
            {
                if (!Path.IsPathRooted(args[i]))
                    fichero = directorioActual + Path.DirectorySeparatorChar + args[i];
                else
                    fichero = args[i];

                if (!File.Exists(fichero))
                    continue;

                Mostrar(fichero);
            }
        }

        static void Mostrar(string fichero)
        {
            using (StreamReader sr = new StreamReader(fichero))
            {
                Console.WriteLine("\n{0}\n", fichero);
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
