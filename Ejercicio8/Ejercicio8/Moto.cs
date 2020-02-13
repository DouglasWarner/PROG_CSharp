using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Moto : Vehiculo
    {

        public Moto(){}

        public Moto(string nom, int nRueda, ConsoleColor c, TipoTraccion t) : base(nom, nRueda, c, t)
        {

        }
    }
}
