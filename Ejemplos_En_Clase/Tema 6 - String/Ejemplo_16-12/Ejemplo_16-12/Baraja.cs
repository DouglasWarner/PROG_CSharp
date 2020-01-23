using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_16_12
{
    class Baraja
    {
        List<Naipe> _baraja = null;

        public Baraja()
        {
            _baraja = new List<Naipe>();
            InicializarBaraja();
        }

        public Naipe Extraer()
        {
            Random rnd = new Random();
            int posicionAExtraer = rnd.Next(_baraja.Count);
            Naipe tmp = _baraja[posicionAExtraer];
            _baraja.RemoveAt(posicionAExtraer);
            return tmp;
        }

        public void VerBaraja()
        {
            foreach (Naipe tmp in _baraja)
            {
                Console.WriteLine(tmp.Info());
            }

            Console.Write(" Listado {0} Naipes. No hay mas naipes a mostrar...", _baraja.Count);
            Console.ReadLine();
        }

        private void InicializarBaraja()
        {
            int nPalos = Enum.GetNames(typeof(Naipe.Palos)).Length;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < nPalos; j++)
                {
                    if (i + 1 == 8 || i + 1 == 9)
                        continue;
                    _baraja.Add(new Naipe((Naipe.Palos)j, i + 1));
                }
            }
        }
    }
}
