using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo7
{
    class Coche : ICarrera
    {
        private string nombre;
        private string marca;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Coche()
        {}

        public Coche(string nom, string mar)
        {
            Nombre = nom;
            Marca = mar;
        }

        public void Correr()
        {
            Console.WriteLine("\n\tEl coche {0} está en marcha...", this);
        }

        public override string ToString()
        {
            return "[ Nombre: " + nombre + " ; Marca: " + Marca + " ]";
        }
    }
}
