using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Jugador
    {
        private int posX;
        private int posY;
        private char icono;

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public char Icono
        {
            get { return icono; }
        }

        public Jugador(int posXInicial, int posYInicial)
        {
            icono = 'J';
            PosX = posXInicial;
            PosY = posYInicial;
        }

        public void MoverJugador(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
