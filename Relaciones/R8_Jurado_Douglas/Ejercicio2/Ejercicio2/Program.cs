/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio2
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 05/03/2020						VERSION: 1.0
 * COMENTARIO: Devuelve información sobre el directorio seleccionado.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------
using System.IO;
using System.Windows.Forms;

namespace Ejercicio2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string directorio = string.Empty;
            OpenFileDialog ventana = new OpenFileDialog();
            FolderBrowserDialog d = new FolderBrowserDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                directorio = d.SelectedPath;
                InfoDirectorio(directorio);
            }

            Console.ReadLine();
        }

        static void InfoDirectorio(string directorio)
        {
            DirectoryInfo dir = new DirectoryInfo(directorio);

            Console.WriteLine("                     INFORMACIÓN DIRECTORIO  ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("           Nombre completo del directorio: {0}", dir.FullName);
            Console.WriteLine("                 Atributos del directorio: {0}", dir.Attributes);
            Console.WriteLine("      Fecha de la creacion del directorio: {0}", dir.CreationTime);
            Console.WriteLine(" Cantidad de directorios en el directorio: {0}", dir.EnumerateDirectories().Count());
            Console.WriteLine("    Cantidad de ficheros en el directorio: {0}", dir.EnumerateFiles().Count());
            Console.WriteLine("                                Extension: {0}", dir.Extension);
            Console.WriteLine("    Fecha del último acceso al directorio: {0}", dir.LastAccessTime);
            Console.WriteLine("          Fecha de la última modificación: {0}", dir.LastWriteTime);
            Console.WriteLine("                                   Nombre: {0}", dir.Name);
            Console.WriteLine("                      El directorio padre: {0}", dir.Parent);
            Console.WriteLine("                   La raíz del directorio: {0}", dir.Root);
        }
    }
}
