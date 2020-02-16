using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Montaña : Bicicleta
    {
        public enum TipoAmortiguacion
        {
            suave, medio, fuerte
        }
        private bool _kitReparacion;
        private int _pulgadasRuedas;
        private TipoAmortiguacion _amortiguacion;

        public bool KitReparacion
        {
            get { return _kitReparacion; }
        }
        public int PulgadasRuedas
        {
            get { return _pulgadasRuedas; }
        }
        public TipoAmortiguacion Amortiguacion
        {
            get { return _amortiguacion; }
        }

        public Montaña() : base()
        { }

        public Montaña(string n, int nR, ConsoleColor c, TipoTraccion t, double pvp, DateTime fCompra, bool kitRepar, int pulgadasR, TipoAmortiguacion amort) 
            : base(n, nR, c, t, pvp, fCompra)
        {
            _kitReparacion = kitRepar;
            _pulgadasRuedas = pulgadasR;
            _amortiguacion = amort;
        }
    }
}
