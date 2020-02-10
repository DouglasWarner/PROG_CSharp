using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class CFechas
    {
        private int dia;
        private int mes;
        private int anio;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public CFechas()
        {

        }

        public CFechas(int dia, int mes, int anio)
        {

        }
    }
}
