using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_09_01_ConceptosPOO
{
    class Vehiculo
    {
        public string n;
        public int p;

        static Vehiculo()
        {
            Console.WriteLine("Constructor estatico");
        }

        public Vehiculo(string nom, int po)
        {
            n = nom;
            p = po;
            Console.WriteLine("Ejecutado vehiculo");
        }

        public void Andar()
        {
            Console.WriteLine(" " + n + " esta andando " + p * 2);
        }

        public class Ejemplo
        {
            public static string texto;
            public string texto2;

            public Ejemplo()
            {
                Console.WriteLine("constructor de la clase interna");
            }
        }

        public override string ToString()
        {
            return String.Format("Nombre {0}; Potencia {1}", n, p);
        }
    }
}
