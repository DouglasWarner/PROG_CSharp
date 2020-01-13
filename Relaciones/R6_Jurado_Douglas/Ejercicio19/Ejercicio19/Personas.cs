using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Personas
    {
        private int _codigo;
        private string _nombre;
        private string _apellidos;
        private string _telefono;
        private bool _borrado;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public bool Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public Personas()
        { }

        public Personas(string nom, string ape, string tlf)
        {
            Nombre = nom;
            Apellidos = ape;
            Telefono = tlf;
            Borrado = false;
        }

        public string VerPersona()
        {
            return String.Format("\t{0}\t{1}\t{2}", Nombre, Apellidos, Telefono);
        }
    }
}
