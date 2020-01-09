using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_09_01_ConceptosPOO
{
    class Coche : Vehiculo
    {
        public string yoquese;

        public Coche(string nombre, int potencia) : base(nombre,potencia)
        {
        }
    }
}
