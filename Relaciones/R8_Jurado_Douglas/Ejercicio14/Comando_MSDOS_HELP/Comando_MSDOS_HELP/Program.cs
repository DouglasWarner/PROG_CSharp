/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio14
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/03/2020						VERSION: 1.0
 * COMENTARIO: App que simula el comando de MS-DOS HELP.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using System.IO;
namespace Comando_MSDOS_HELP
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 1)
            {
                Console.WriteLine("\nSintasis: AYUDA [comando]");
                return;
            }

            if (args.Length == 1)
            {
                switch (args[0].ToLower())
                {
                    case "ficheros":
                        Console.WriteLine("\nSintasis: FICHEROS [directorio]");
                        break;
                    case "copiar":
                        Console.WriteLine("\nSintasis: COPIAR origen [origen ...] [destino]");
                        break;
                    case "borrar":
                        Console.WriteLine("\nSintasis: BORRAR archivo [archivo ...]");
                        break;
                    case "mostrar":
                        Console.WriteLine("\nSintasis: MOSTRAR archivo [archivo ...]");
                        break;
                    case "buscar":
                        Console.WriteLine("\nSintasis: BUSCAR \"cadena\" archivo [archivo ...]");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("FICHEROS:    Muestra todos los ficheros de un directorio");
                Console.WriteLine("COPIAR:      Copia uno o varios archivos en otra ubicación");
                Console.WriteLine("BORRAR:      Borra uno o más archivos");
                Console.WriteLine("MOSTRAR:     Muestra el contenido de un archivo");
                Console.WriteLine("ENCONTRA:    Busca una cadena de texto en un o más archivos");
            }
        }
    }
}
