using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Paseo : Bicicleta
    {
        private int _nCestas;
        private string _modelo;
        private string _marca;

        public int NCestas
        {
            get { return _nCestas; }
        }
        public string Modelo
        {
            get { return _modelo; }
        }
        public string Marca
        {
            get { return _marca; }
        }

        public Paseo() : base(){}

        public Paseo(string n, int nR, ConsoleColor c, TipoTraccion t, double pvp, DateTime fCompra, int cestas, string model, string marc) :base(n, nR, c, t, pvp, fCompra)
        {
            _nCestas = cestas;
            _modelo = model;
            _marca = marc;
        }
    }
}
