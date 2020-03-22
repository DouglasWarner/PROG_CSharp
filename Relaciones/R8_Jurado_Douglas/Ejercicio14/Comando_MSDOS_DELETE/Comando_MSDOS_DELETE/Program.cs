/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS DELETE.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;

namespace Comando_MSDOS_DELETE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ficheros = null;

            if (args.Length < 1)
                return;

            ficheros = args;

            Borrar(ficheros);
        }

        static void Borrar(string[] archivosABorrar)
        {
            int nBorrados = 0;

            foreach (string item in archivosABorrar)
            {
                if (Path.IsPathRooted(item))
                {
                    if (Directory.Exists(item))
                    {
                        nBorrados += Directory.GetFiles(item).Length;
                        Directory.Delete(item);
                    }
                }
                else
                {
                    if (File.Exists(item))
                    {
                        nBorrados++;
                        File.Delete(item);
                    }
                }
            }
        }
    }
}
