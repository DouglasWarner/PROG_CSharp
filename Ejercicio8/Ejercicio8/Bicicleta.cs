using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Bicicleta : Vehiculo
    {
        private double _precio;
        private DateTime _fechacompra;

        public double Precio
        {
            get { return _precio; }
        }

        public DateTime Fechacompra
        {
            get { return _fechacompra; }
        }

        public Bicicleta() : base()
        {}

        public Bicicleta(string n, int nR, ConsoleColor c, TipoTraccion t, double pvp, DateTime fCompra) : base(n, nR, c, t)
        {
            _precio = pvp;
            _fechacompra = fCompra;
        }
    
    }
}
