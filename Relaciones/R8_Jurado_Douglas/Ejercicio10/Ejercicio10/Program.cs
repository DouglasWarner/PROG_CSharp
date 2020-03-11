/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio10
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 11/03/2020						VERSION: 1.0
 * COMENTARIO: Muestra el contenido de un fichero de texto alreves.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------
using System.IO;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Douglas_Programacion\Relaciones\R8_Jurado_Douglas\fichero2.txt";

            Console.WriteLine("Lectura de un fichero al reves");
            Console.WriteLine("\nFichero: {0}", Path.GetFileName(ruta));
            Console.WriteLine("".PadLeft(100,'-'));
            MostrarAlReves(ruta);

            Console.ReadLine();
        }

        static void MostrarAlReves(string fichero)
        {
            if (!File.Exists(fichero))
            {
                Console.WriteLine("El fichero no existe");
                return;
            }

            using (FileStream fs = new FileStream(fichero, FileMode.Open, FileAccess.Read))
            {
                for (long i = fs.Length - 1; i >= 0; i--)
                {
                    fs.Position = i;
                    Console.Write((char)fs.ReadByte());
                }
            }

            // Mirar porque no funciona esta forma.
            /*using (StreamReader sr = new StreamReader(fichero))
            {
                for (long i = sr.BaseStream.Length - 1; i >= 0; i--)
                {
                    sr.BaseStream.Position = i;
                    Console.Write((char)sr.Read());
                }
            }*/
        }
    }
}
