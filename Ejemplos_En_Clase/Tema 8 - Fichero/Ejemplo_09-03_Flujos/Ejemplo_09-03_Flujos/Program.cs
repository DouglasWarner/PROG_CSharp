using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//_----------------------
using System.IO;

namespace Ejemplo_09_03_Flujos
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\ficheros\ejemplo_09-03_flujos.txt";

            Console.WriteLine("Escribiendo en la consola....");

            // Cambio el flujo de salida al fichero
            FileStream fs = new FileStream(ruta, FileMode.Open);

            // MIRAR ESTO CON UN ARCHIVO GRANDE
            for (long i = 0; i < fs.Length; i++)
            {
                Console.WriteLine("-");
            }

            Console.ReadLine();

            // Flujo de salida de la consola
            TextWriter tmp = Console.Out;


            StreamWriter sw = new StreamWriter(fs);

            // Hacer que la salida sea al nuevo flujo sw
            Console.SetOut(sw);

            Console.WriteLine("Este texto no se verá en la consola");
            Console.WriteLine("se escribira en el fichero");

            // Vuelvo a la consola
            Console.SetOut(tmp);

            Console.WriteLine("Hola caracola, he vuelto...");

            sw.Close();

            Console.ReadLine();

        }
    }
}
