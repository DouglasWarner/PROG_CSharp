/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 11/03/2020						VERSION: 1.0
 * COMENTARIO: Accediendo a un componente de ventana de windows, selecciona un fichero y cuenta el número de líneas que hay,
 *             su tamaño, sus atributos, número de palabras.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------
using System.IO;
using System.Windows.Forms;

namespace Ejercicio12
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string ruta = string.Empty;
            OpenFileDialog ventana = new OpenFileDialog();

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                ruta = ventana.FileName;
            }
            else
                return;

            Console.WriteLine("\n Fichero seleccionado: {0}", ruta);
            Console.WriteLine("  Atributos del fichero: {0}", File.GetAttributes(ruta));
            Console.WriteLine("     Tamaño del fichero: {0} kb", new FileInfo(ruta).Length / 1024);
            Console.WriteLine("       Número de Lineas: {0}", NLineasFichero(ruta));
            Console.WriteLine("     Número de palabras: {0}", NPalabrasFichero(ruta));


            Console.ReadLine();
        }

        static int NLineasFichero(string fichero)
        {
            int nLineas = 0;

            if (!File.Exists(fichero))
                return -1;

            try
            {
                using(StreamReader sr = new StreamReader(fichero))
                {
                    while (sr.ReadLine() != null)
                    {
                        nLineas++;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return nLineas;
        }

        static int NPalabrasFichero(string fichero)
        {
            string linea = string.Empty;
            int nPalabras = 0;
            char[] separadores = { ' ', '-', ',', ';', ':' };

            if (!File.Exists(fichero))
                return -1;

            try
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] splitLinea = linea.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
                        nPalabras += splitLinea.Length;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            return nPalabras;
        }
    }
}
