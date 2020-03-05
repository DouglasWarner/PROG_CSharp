/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio1
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 05/03/2020						VERSION: 1.0
 * COMENTARIO: Devuelve información sobre el fichero seleccionado.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using System.IO;
using System.Windows.Forms;

namespace Ejercicio1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string ruta = string.Empty;
            OpenFileDialog fichero = new OpenFileDialog();

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                ruta = fichero.FileName;
                InfoFicheroActual(ruta);
            }

            Console.ReadLine();
        }

        static void InfoFicheroActual(string ruta)
        {
            Console.WriteLine("                 INFORMACION DEL FICHERO     ");
            Console.WriteLine("---------------------------------------------------------------------------------------\n");
            Console.WriteLine("            Ruta y fichero original: {0}", ruta);
            Console.WriteLine("                          Extensión: {0}", Path.GetExtension(ruta));
            Console.WriteLine("        Nombre completo del fichero: {0}", Path.GetFileName(ruta));
            Console.WriteLine("   Nombre del fichero sin extensión: {0}", Path.GetFileNameWithoutExtension(ruta));
            Console.WriteLine("     Obtener directorio del fichero: {0}", Path.GetDirectoryName(ruta));
            Console.WriteLine("                    Directorio raíz: {0}", Path.GetPathRoot(ruta));
            Console.WriteLine("    Determina si contiene extension: {0}", Path.HasExtension(ruta));
            Console.WriteLine("     Determina si contiene una raíz: {0}", Path.IsPathRooted(ruta));
            Console.WriteLine("              Atributos del fichero: {0}", File.GetAttributes(ruta));
            Console.WriteLine("   Fecha de la creación del fichero: {0}", File.GetCreationTime(ruta));
            Console.WriteLine("Fecha del último acceso del fichero: {0}", File.GetLastAccessTime(ruta));
            Console.WriteLine("    Fecha de la última modificación: {0}", File.GetLastWriteTime(ruta));
        }
    }
}
