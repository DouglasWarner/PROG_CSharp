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

            Coche c1 = new Coche("Seat", 90);

            Vehiculo v2 = new Coche("Fiat",100);

            v1.Andar("Vehiculo");

            c1.Andar("Coche");

            v2.Andar("Coche");

            Console.ReadLine();
        }
    }
}
