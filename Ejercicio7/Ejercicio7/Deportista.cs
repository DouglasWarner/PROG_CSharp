using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo7
{
    class Deportista : ICarrera
    {
        private string nombre;
        private int dorsal;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dorsal
        {
            get { return dorsal; }
            set { dorsal = value; }
        }

        public Deportista()
        {}

        public Deportista(string nom, int dor)
        {
            Nombre = nom;
            Dorsal = dor;
        }

        public void Correr()
        {
            Console.WriteLine("\n\tEl corredor {0} de fondo está en ello...", this);
        }

        public override string ToString()
        {
            return "[ Nombre: " + nombre + " ; Dorsal: " + dorsal.ToString("00") + " ]";
        }
    }
}
