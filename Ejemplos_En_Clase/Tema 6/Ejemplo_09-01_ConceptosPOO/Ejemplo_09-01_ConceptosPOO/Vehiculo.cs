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
        int p;

        public Vehiculo(string nom, int po)
        {
            n = nom;
            p = po;
        }

        public void Andar(string nombre)
        {
            Console.WriteLine(nombre + " " + n + " esta andando " +p * 2);
        }
    }
}
