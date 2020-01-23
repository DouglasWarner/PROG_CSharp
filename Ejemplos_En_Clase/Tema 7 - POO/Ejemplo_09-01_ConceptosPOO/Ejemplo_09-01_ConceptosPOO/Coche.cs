using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_09_01_ConceptosPOO
{
    class Coche : Vehiculo
    {
        public string Marca;

        public Coche(string nombre, int potencia, string marca)
            : base(nombre, potencia)
        {
            Marca = marca;
            Console.WriteLine("Ejecutando coche");
        }

        /*public void Andar()
        {
            Console.WriteLine(" " + n + " esta andando " + p * 2);
        }*/
    }
}
