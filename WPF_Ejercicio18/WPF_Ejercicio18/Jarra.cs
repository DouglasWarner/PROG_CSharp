using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_Ejercicio18
{
    class Jarra
    {
        private int _capacidad;
        private int _contenido;

        public int Capacidad
        {
            get { return _capacidad; }
        }
        public int Contenido
        {
            get { return _contenido; }
            set
            {
                _contenido = value;
            }
        }

        public Jarra(int capacidad)
        {
            _capacidad = capacidad;
        }
        
        public void Llenar()
        {
            Contenido = Capacidad;
        }

        public void Vaciar()
        {
            Contenido = 0;
        }

        public void LlenarDesdeJarra(Jarra otraJarra)
        {
            // Mirar formula matematica
            if (Contenido < Capacidad)
                Contenido = 0;
            if (otraJarra.Contenido > 0)
                otraJarra.Contenido -= Contenido;
        }

        public override string ToString()
        {
            return Contenido.ToString() + "/" + Capacidad.ToString();
        }
    }
}
