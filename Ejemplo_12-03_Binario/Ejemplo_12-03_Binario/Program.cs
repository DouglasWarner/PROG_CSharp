using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using System.IO;

namespace Ejemplo_12_03_Binario
{
    class Program
    {
        static string directorio = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "datos";
        static string ficheroBaraja = "." + Path.DirectorySeparatorChar + "datos" + Path.DirectorySeparatorChar + "baraja.dat";

        static void Main(string[] args)
        {
            Naipe n1 = new Naipe();
            n1.valor = 100;
            n1.palo = "Copas";
            n1.peso = 8.0F;
            n1.nombre = "Ocho";

            if(!Directory.Exists(directorio))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "datos");

            Guardar(n1);

            Leer();

            Naipe tmp;
            Leer(out tmp);

            Console.WriteLine(tmp.ToString());

            Console.ReadLine();
        }

        static bool Guardar(Naipe n)
        {
            try
            {   using(FileStream fs = new FileStream(ficheroBaraja, FileMode.Append, FileAccess.Write))
                using (BinaryWriter escritor = new BinaryWriter(fs, Encoding.Default))
                {
                    escritor.Write(n.valor);
                    escritor.Write(n.palo);
                    escritor.Write(n.peso);
                    escritor.Write(n.nombre);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        static bool Leer()
        {
            try
            {
                using (FileStream fs = new FileStream(ficheroBaraja, FileMode.Open, FileAccess.Read))
                using (BinaryReader lector = new BinaryReader(fs, Encoding.Default))
                {
                    /*try
                    {
                        while (true)
                        {
                            Naipe tmp = new Naipe();
                            tmp.valor = lector.ReadInt32();
                            tmp.palo = lector.ReadString();
                            tmp.peso = lector.ReadSingle();
                            tmp.nombre = lector.ReadString();
                            
                            // Mostrarlo
                            Console.WriteLine(tmp.ToString());
                        }
                    }
                    catch
                    {
                        Console.Write("\n\nFin del listado...");
                        Console.ReadLine();
                    }*/

                    while (lector.PeekChar() != -1)
                    {
                        Naipe tmp = new Naipe();
                        tmp.valor = lector.ReadInt32();
                        tmp.palo = lector.ReadString();
                        tmp.peso = lector.ReadSingle();
                        tmp.nombre = lector.ReadString();
                        // Mostrarlo
                        Console.WriteLine(tmp.ToString());
                    }

                    Console.Write("\n\nFin del listado...");
                    Console.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        // Otra forma de hacerlo
        static bool Leer(out Naipe n)
        {
            using(FileStream fs = new FileStream(ficheroBaraja, FileMode.Open, FileAccess.Read))
            using (BinaryReader lector = new BinaryReader(fs, Encoding.Default))
            {
                n = new Naipe();
                n.valor = lector.ReadInt32();
                n.palo = lector.ReadString();
                n.peso = lector.ReadSingle();
                n.nombre = lector.ReadString();

                // Tendria que guarda la posicion por donde voy, en alguna variable de la clase (en este caso estatica) despues de leer los datos.
                return true;
            } throw new IOException();
        }
    }
}
