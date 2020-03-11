using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------
using System.IO;

namespace Ejemplo_11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Douglas_Programacion\Ejemplos_En_Clase\Tema 8 - Fichero\texto2.txt";

            //Mostrar(ruta);

            //MostrarUnoAUno(ruta);

            EscribirTabla(ruta, 5);

            MostrarUnoAUno(ruta);

            Console.ReadLine();
        }

        #region Lectura de ficheros de texto

        static void Mostrar(string fichero)
        {
            char caracter;
            if (!File.Exists(fichero))
                return;


            using (FileStream fs = new FileStream(fichero, FileMode.Open, FileAccess.Read))
            {
                /*fs.Seek(5, SeekOrigin.Begin);
                for (long i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine((char)fs.ReadByte());
                }
                */
                
                while(true)
                {
                    caracter = (char)fs.ReadByte();

                    if ((int)caracter == -1)
                    {
                        Console.WriteLine("fin");
                        return;
                    }
                    if (fs.Position != fs.Length)
                        Console.WriteLine(caracter);
                    else
                        return;
                }

                /*for (long i = fs.Length-1; i >= 0; i--)
                {
                    fs.Position = i;
                    Console.WriteLine((char)fs.ReadByte());
                }*/
            }
        }

        static void MostrarUnoAUno(string fichero)
        {
            int letra;
            string linea;

            if (!File.Exists(fichero))
                return;

            using (StreamReader sr = new StreamReader(fichero, Encoding.UTF8))
            {
                while ((letra = sr.Read()) != -1)
                {
                    Console.Write((char)letra);
                }

                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                Console.WriteLine("\n----------------------------------");
                
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }

        #endregion

        #region Escritura de ficheros de texto

        static void EscribirTabla(string fichero, int nTabla)
        {
            if (!Directory.Exists(Path.GetDirectoryName(fichero)))
                return;

            using (StreamWriter sw = new StreamWriter(fichero))
            {
                for (int i = 0; i <= 10; i++)
                {
                    sw.WriteLine(i.ToString() + " x " + nTabla + " = " + (i * nTabla).ToString());
                }
            }
        }

        #endregion
    }
}
