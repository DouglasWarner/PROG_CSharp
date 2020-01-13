using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_09_01_ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo v1 = new Vehiculo("Bici", 10);

            Coche c1 = new Coche("Seat", 90, "yoquese");

            Vehiculo v2 = new Coche("Fiat",100, "yoquese");

            v1.Andar();

            c1.Andar();

            v2.Andar();

            Vehiculo.Ejemplo ej = new Vehiculo.Ejemplo();

            Console.WriteLine("\n\n");

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
