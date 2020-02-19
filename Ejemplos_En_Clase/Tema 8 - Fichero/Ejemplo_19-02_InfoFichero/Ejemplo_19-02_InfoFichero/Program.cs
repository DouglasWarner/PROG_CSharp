using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------
using System.IO;
using System.Collections;

namespace Ejemplo_19_02_InfoFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\ficheros\v1.txt";
            string ruta1 = @"C:\ficheros\v2.txt";
            string directorio = @"C:\ficheros";
            string[] dias = {"Primera aplicación", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            if(!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);
            if(!File.Exists(ruta))
                File.Create(ruta);
            if (!File.Exists(ruta1))
                using (File.Create(ruta1)) { };


            InfoFicheroActual(ruta);
            Console.WriteLine("\n");
            InfoUnidades();

            File.AppendAllLines(ruta1, dias);
            StreamWriter escritor = File.AppendText(ruta1);
            escritor.WriteLine("++++++++++++++++++++++");
            escritor.Close();


            Mostrar(ruta1);

            Console.ReadLine();
        }

        static void Mostrar(string ruta)
        {
            string[] contenido = File.ReadAllLines(ruta);
            foreach (var item in contenido)
            {
                Console.WriteLine(item);
            }
        }

        static void InfoUnidades()
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();

            Console.WriteLine(" Hay {0} unidades disponibles ", unidades.Length);
            foreach (var item in unidades)
            {
                if (item.IsReady)
                {
                    Console.WriteLine("             Nombre: {0} ", item.Name);
                    Console.WriteLine("Sistema de archivos: {0}", item.DriveFormat);
                    Console.WriteLine("              Total: {0}", item.TotalSize);
                    Console.WriteLine("Espacio libre total: {0}", item.AvailableFreeSpace);
                    // etc...
                }

                Console.WriteLine("\n---------------------------------------------\n");
            }
        }

        static void InfoFicheroActual(string ruta)
        {
            // Muestra informacion divera de la ruta
            Console.WriteLine("          Ruta y fichero original: {0}", ruta);
            Console.WriteLine("                        Extensión: {0}", Path.GetExtension(ruta));
            Console.WriteLine("      Nombre completo del fichero: {0}", Path.GetFileName(ruta));
            Console.WriteLine(" Nombre del fichero sin extensión: {0}", Path.GetFileNameWithoutExtension(ruta));
            Console.WriteLine("         Obtener mi ruta absoluta: {0}", Path.GetFullPath(Directory.GetCurrentDirectory()));
        }
    }
}
