using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_GestionNaipes
{
    class GestionBaraja
    {
        private Random _rnd = new Random();
        const int TAMANOBARAJA = 1;
        public enum Palos { Oro, Espada, Copas, Basto }
        public enum Valor { Uno = 1, Dos, Tres, Cuatro, Cinco, Seis, Siete, Sota = 10, Caballo, Rey }

        public struct Naipe
        {
            Valor valor;
            Palos palo;

            public Naipe(Palos p, Valor v)
            {
                valor = v;
                palo = p;
            }

            public void VerNaipe()
            {
                Console.Write(" {0} de {1}, ", valor, palo);
            }
        }

        int nDatos = 0;

        Naipe[] Baraja = new Naipe[100];
        //Naipe[] Baraja = new Naipe[TAMANOBARAJA];

        public bool Anadir(Naipe naipe)
        {
            if (nDatos == Baraja.Length)
                return false;
            Baraja[nDatos++] = naipe;
            return true;
        }

        // True lo muestra con salto de linea, False lo muestra en la misma linea.
        public void VerBaraja(bool formato)
        {
            if (formato)
            {
                for (int i = 0; i < nDatos; i++)
                {
                    Baraja[i].VerNaipe();
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < nDatos; i++)
                {
                    Baraja[i].VerNaipe();
                }
            }
        }

        public bool LlenarBaraja(int cuantos)
        {
            int valor;
            int palo;

            for (int i = 0; i < cuantos; i++)
            {
                valor = _rnd.Next(1, Enum.GetValues(typeof(GestionBaraja.Valor)).Length);
                if (valor == 8 || valor == 9)
                    valor = (int)Valor.Sota;
                palo = _rnd.Next((int)Palos.Basto);

                Anadir(new Naipe((Palos)palo, (Valor)valor));
            }

            return true;
        }

        public void Inicializar()
        {
            nDatos = 0;
        }
    }
}
