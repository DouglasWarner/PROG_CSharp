using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_22_01_delegate
{
    class Evento
    {
        public delegate void DlgMio(string mensage);
        public event DlgMio MiEvento;

        public void MetodoEvento()
        {
            if (MiEvento != null)
                MiEvento("hola desde evento");
        }
    }
}
