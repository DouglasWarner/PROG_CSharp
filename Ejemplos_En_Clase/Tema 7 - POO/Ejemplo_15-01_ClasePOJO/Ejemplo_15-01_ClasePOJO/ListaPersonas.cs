using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_15_01_ClasePOJO
{
    class ListaPersonas
    {
        private List<Persona> _listaPersona = new List<Persona>();
        private int _codigoPersona = 100;

        public int Cuantos
        {
            get { return _listaPersona.Count; }
        }

        public bool Anadir(Persona p)
        {
            _listaPersona.Add(p);

            return true;
        }
    }
}
