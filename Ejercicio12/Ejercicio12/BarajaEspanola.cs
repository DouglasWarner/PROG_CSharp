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
        public struct Carta
        {
            public enum Valor
            {
                Uno, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Sota, Caballo, Rey
            }

            public enum Palo
            {
                Or, Co, Es, Ba
            }

            Valor valor;
            Palo palo;

            public Carta(Palo p, Valor v)
            {
                valor = v;
                palo = p;
            }

            public void VerCarta()
            {
                Console.Write("[{0}, {1}]   ", valor, palo);
            }
            
        }
        
        int _nDatosValor = Enum.GetNames(typeof(Carta.Valor)).Length;
        int _nDatosPalo = Enum.GetNames(typeof(Carta.Palo)).Length;
        Carta[] _baraja = null;
        const int TAMANOBARAJA = 48;

        public BarajaEspanola()
        {
            _baraja = new Carta[TAMANOBARAJA];
            LlenarBaraja();
        }

        private void LlenarBaraja()
        {
            int j = 0;

            for (int i = 0; i < TAMANOBARAJA; i++)
            {
                _baraja[i] = new Carta((Carta.Palo)i, (Carta.Valor)j);
            }
        }

        public void MostrarBaraja()
        {
            for (int i = 0; i < TAMANOBARAJA; i++)
            {
                _baraja[i].VerCarta();
            }
        }
        
        public void MostrarBaraja(string[,] baraja)
        {
            int nDatosPalo = baraja.GetLength(0);
            int nDatosValor = baraja.GetLength(1);

            for (int i = 0; i < nDatosPalo; i++)
            {
                for (int j = 0; j < nDatosValor; j++)
                {
                    if (baraja[i, j] == null)
                        return;

                    Console.Write(baraja[i,j].PadLeft(15));
                    if (j == nDatosValor / 2)
                        Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }

        private int ComprobarCarta(int posPalo, int posValor)
        {
            return 1;
        }

        public string[,] SacarCartas()
        {
            Random rnd = new Random();
            string[,] tmpBaraja = new string[_nDatosPalo, _nDatosValor];
            int aleaPalo = 0;
            int aleaValor = 0;
            int pausa = 100;
            int posPalo = _nDatosPalo;
            int posValor = _nDatosValor;

            for (int i = 0; i < _nDatosPalo; i++)
            {
                for (int j = 0; j < _nDatosValor; j++)
                {
                    aleaPalo = rnd.Next(_nDatosPalo);
                    aleaValor = rnd.Next(_nDatosValor);

                    if (ComprobarCarta(aleaPalo, aleaValor) == 1)
                    {
                        //tmpBaraja[i, j] = _baraja[aleaPalo, aleaValor];
                        //_baraja[aleaPalo, aleaValor] = "";
                    }
                    else
                        j--;
                    
                    Console.Clear();
                    MostrarBaraja();
                    Console.WriteLine("==============================");
                    MostrarBaraja(tmpBaraja);

                    Thread.Sleep(pausa);
                }
            }
            return tmpBaraja;
        }
    }
}
