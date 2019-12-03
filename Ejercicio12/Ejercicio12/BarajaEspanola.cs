﻿using System;
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
            Uno, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Sota, Caballo, Rey
        }

        public enum Palo
        {
            Or, Co, Es, Ba
        }
        
        int _nDatosValor = Enum.GetNames(typeof(Valor)).Length;
        int _nDatosPalo = Enum.GetNames(typeof(Palo)).Length;

        string[,] _baraja = null;

        public BarajaEspanola()
        {
            _baraja = new string[_nDatosPalo, _nDatosValor];
            LlenarBaraja();
        }

        private void LlenarBaraja()
        {
            for (int i = 0; i < _nDatosPalo; i++)
            {
                for (int j = 0; j < _nDatosValor; j++)
                {
                    _baraja[i, j] = string.Format("[{0}, {1}]  ", (Palo)i, (Valor)j);
                }
            }
        }

        public void MostrarBaraja()
        {
            for (int i = 0; i < _nDatosPalo; i++)
            {
                for (int j = 0; j < _nDatosValor; j++)
                {
                    if(j == _nDatosValor/2 )
                        Console.WriteLine();    // Para darle formato al mostrarlo en consola.
                    Console.Write(_baraja[i,j].PadLeft(15));
                }
                Console.WriteLine("\n");
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
                    if (j == nDatosValor / 2)   // Para darle formato al mostrarlo en consola.
                        Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }

        private int ComprobarCarta(int posPalo, int posValor)
        {
            if (_baraja[posPalo, posValor] == "")
                return -1;

            return 1;
        }

        public string[,] SacarCartas()
        {
            Random rnd = new Random();
            string[,] tmpBaraja = new string[_nDatosPalo, _nDatosValor];
            int aleaPalo = 0;
            int aleaValor = 0;
            int pausa = 100;

            for (int i = 0; i < _nDatosPalo; i++)
            {
                for (int j = 0; j < _nDatosValor; j++)
                {
                    aleaPalo = rnd.Next(_nDatosPalo);
                    aleaValor = rnd.Next(_nDatosValor);

                    if (_baraja[aleaPalo,aleaValor] != "")
                    {
                        tmpBaraja[i, j] = _baraja[aleaPalo, aleaValor];
                        _baraja[aleaPalo, aleaValor] = "";
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
