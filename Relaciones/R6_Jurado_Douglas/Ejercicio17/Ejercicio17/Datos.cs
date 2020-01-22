using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Datos
    {
        private string _nombre;
        private static int _codigo;
        private DateTime _fecha;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Datos()
        {}

        public Datos(string n, DateTime f)
        {
            Nombre = n;
            _codigo++;
            Fecha = f;
        }

        public override string ToString()
        {
            return _codigo + "; " + Nombre + "; " + Fecha;
        }
    }
}
