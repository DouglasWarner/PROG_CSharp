using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ProbarAbrirFicheroAbiertoPorOtroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\ficheros\v1.txt";
            string ruta1 = @"C:\ficheros\v2.txt";
            string directorio = @"C:\ficheros";
            string[] dias = {"Segunda aplicación", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            if (!File.Exists(ruta))
                File.Create(ruta);
            if (!File.Exists(ruta1))
                using (File.Create(ruta1)) { };

            File.AppendAllLines(ruta1, dias);
            StreamWriter escritor = File.AppendText(ruta1);
            escritor.WriteLine("++++++++++++++++++++++");
            Console.ReadLine();
            escritor.Close();

            Console.ReadLine();
        }
    }
}
