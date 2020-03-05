using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Tesoro
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

        public Tesoro(int posXInicial, int posYInicial)
        {
            icono = 'T';
            PosX = posXInicial;
            PosY = posYInicial;
        }

        public void MoverTesoro(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public void MostrarTesoro()
        {
            Console.CursorLeft = PosY;
            Console.CursorTop = PosX;
            Console.Write(Icono);
        }

    }
}
