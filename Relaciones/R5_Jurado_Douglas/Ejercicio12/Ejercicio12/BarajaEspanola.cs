using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio12
{
    class BarajaEspanola
    {
        public enum Valor
        {
            Uno = 1, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Sota, Caballo, Rey
        }

        public enum Palo
        {
            Or = 1, Co, Es, Ba
        }
        
        int _nDatosValor = Enum.GetNames(typeof(Valor)).Length+1;
        int _nDatosPalo = Enum.GetNames(typeof(Palo)).Length+1;
        string[] _baraja = null;
        const int TAMANOBARAJA = 48;

        public BarajaEspanola()
        {   
            _baraja = new string[TAMANOBARAJA];
            LlenarBaraja();
        }

        public void MostrarBaraja()
        {
            Console.CursorLeft = 3;

            for (int i = 0; i < TAMANOBARAJA; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("\n");
                    Console.CursorLeft = 3;
                }
                Console.Write("{0} ", _baraja[i].ToString().PadLeft(15));
            }
        }

        public string[] SacarCartas()
        {
            Random rnd = new Random();
            string[] tmpBaraja = new string[TAMANOBARAJA];
            int posAleaPalo = 0;
            int posAleaValor = 0;
            int posicion = 0;
            int pausa = 10;
            int tamano = TAMANOBARAJA;

            for (int i = 0; i < TAMANOBARAJA; i++)
            {
                posAleaPalo = rnd.Next(_nDatosPalo);
                posAleaValor = rnd.Next(_nDatosValor);
                posicion = posAleaPalo * posAleaValor;
                if (posicion <= tamano && _baraja[posicion] != "")
                {
                    tmpBaraja[i] = _baraja[posicion];
                    _baraja[posicion] = "";
                    tamano = ExtraerCarta(posicion, tamano);
                    MostrarExtraerCarta(tmpBaraja, pausa, i);
                }
                else
                    i--;
            }

            Console.Write("Eso es todo... ");
            LlenarBaraja();
            return tmpBaraja;
        }

        #region Mis Metodos Privados
        private void LlenarBaraja()
        {
            int posicion = 0;

            for (int i = 1; i < _nDatosPalo; i++)
            {
                for (int j = 1; j < _nDatosValor; j++)
                {
                    _baraja[posicion++] = string.Format("[{0}, {1}]  ", (Valor)j, (Palo)i);
                }
            }
        }
        private void MostrarBaraja(string[] baraja, int posHasta)
        {
            Console.CursorLeft = 3;
            Console.WriteLine("     Extrallendo Cartas  ");
            for (int i = 0; i <= posHasta; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine("\n");
                Console.Write("{0} ", baraja[i].ToString().PadLeft(15));
            }
        }
        private void MostrarExtraerCarta(string[] tmpBaraja, int pausa, int i)
        {
            Console.Clear();
            MostrarBaraja();
            Console.WriteLine("\n" + new string('=', 100));
            MostrarBaraja(tmpBaraja, i);
            Thread.Sleep(pausa);
        }
        private int ExtraerCarta(int posicion, int tamano)
        {
            for (int j = posicion; j < tamano - 1; j++)
            {
                _baraja[j] = _baraja[j + 1];
            }
            _baraja[--tamano] = "";
            return tamano;
        }
        #endregion
    }
}
