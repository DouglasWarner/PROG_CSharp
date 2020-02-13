using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Moto : Vehiculo
    {
        public enum TipoCombustible
        {
            mezcla,
            normal
        }
        private int _potencia;
        private TipoCombustible _combustible;

        public int Potencia
        {
            get { return _potencia; }
        }
        public TipoCombustible Combustible
        {
            get { return _combustible; }
        }

        public Moto() : base(){}

        public Moto(string nom, int nRueda, ConsoleColor c, TipoTraccion t, int pt, TipoCombustible comb) : base(nom, nRueda, c, t)
        {
            _potencia = pt;
            _combustible = comb;
        }
    }
}
