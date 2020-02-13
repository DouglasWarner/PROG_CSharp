using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Coche : Vehiculo
    {
        public enum Estado
        {
            marchando,
            parado
        }

        private int _velocidadMax;
        private Estado _estadoActual;
        
        public int VelocidadMax
        {
            get { return _velocidadMax; }
        }
        public Estado EstadoActual
        {
            get { return _estadoActual; }
        }

        public Coche() : base(){}

        public Coche(string nom, int nRueda, ConsoleColor c, TipoTraccion t ,int veloMax)
            : base(nom, nRueda, c, t)
        {
            _velocidadMax = veloMax;
            _estadoActual = Estado.parado;
        }

        public void Marchar()
        {
            if (EstadoActual == Estado.marchando)
            {
                Console.WriteLine("\tEl {0}, ya se encuentra en marcha", this);
                return;
            }

            Console.WriteLine("\tEl {0}, esta andando", this);
            _estadoActual = Estado.marchando;
        }

        public void Parar()
        {
            if (EstadoActual == Estado.parado)
            {
                Console.WriteLine("\tEl {0}, ya se encuentra en parado", this);
                return;
            }

            Console.WriteLine("\tEl {0}, se para", this);
            _estadoActual = Estado.parado;
        }

    }
}
