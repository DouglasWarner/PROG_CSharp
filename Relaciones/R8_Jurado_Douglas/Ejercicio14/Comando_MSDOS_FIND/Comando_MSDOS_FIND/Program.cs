/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS FIND.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using System.IO;

namespace Comando_MSDOS_FIND
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = string.Empty;
            string[] ficheros = null;
            string[] texto = System.Environment.CommandLine.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length < 2)
                return;

            if (texto.Length < 3)
            {
                Console.WriteLine("\nError de formato. La cadena a de estar entre comillas.");
                return;
            }

            try
            {
                cadena = texto[1];
                ficheros = args.Skip(1).ToArray();
                
                for (int i = 0; i < ficheros.Length; i++)
                {
                    if (!Path.IsPathRooted(ficheros[i]))
                        ficheros[i] = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + ficheros[i];

                    Console.WriteLine("\n-------- {0}", ficheros[i].ToUpper());

                    Buscar(ficheros[i], cadena);
                }
            }
            catch
            {
                Console.WriteLine("\nError de formato");
            }
        }

        static void Buscar(string fichero, string cadena)
        {
            string lineaLeida = string.Empty;

            using (StreamReader sr = new StreamReader(fichero))
            {
                while (!sr.EndOfStream)
                {
                    lineaLeida = sr.ReadLine();
                    if (lineaLeida.Contains(cadena))
                        Console.WriteLine(lineaLeida);
                }
            }
        }
    }
}
