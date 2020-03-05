using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ejemplo_Fichero_DialogResult
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string rutaCompleta = string.Empty;
            

            OpenFileDialog fichero = new OpenFileDialog();

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                rutaCompleta = fichero.FileName;
                Console.WriteLine(rutaCompleta);
                MessageBox.Show("Tu ruta seleccionada es " + rutaCompleta);
                PonerAtributos(rutaCompleta);

            }

            // Obtiene el directorio del ejecutable
            System.Console.WriteLine(Application.StartupPath);


            // Obtiene el tiempo de ejecución desde el momento del método Start().
            Stopwatch tmp = new Stopwatch();

            tmp.Start();

            Console.ReadLine();

            Console.WriteLine(tmp.Elapsed.TotalMinutes);

            tmp.Stop();
            
            Console.ReadLine();
        }

        static void PonerAtributos(string fichero)
        {
            FileInfo f = new FileInfo(fichero);
            f.Attributes = FileAttributes.ReadOnly | FileAttributes.Hidden;
        }
    }
}
