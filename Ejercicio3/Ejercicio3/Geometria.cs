using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }

        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Cuadrado
    {
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;
        private int _lado;
        private int _area;
        private int _perimetro;

        public Punto Vertice1
        {
            get { return _vertice1; }
        }
        public Punto Vertice2
        {
            get { return _vertice2; }
        }
        public Punto Vertice3
        {
            get { return _vertice3; }
        }
        public Punto Vertice4
        {
            get { return _vertice4; }
        }

        public int Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }
        public int Area
        {
            get { return _area; }
        }
        public int Perimetro
        {
            get { return _perimetro; }
        }

        public Cuadrado(Punto v1, Punto v3)
        {
            _vertice1 = v1;
            _vertice3 = v3;
            Lado = _vertice1.X + _vertice3.Y;
            _perimetro = 4 * Lado;
            _area = Lado * Lado;
            _vertice2 = new Punto(v3.X, v1.Y);
            _vertice4 = new Punto(v1.X, v3.Y);
        }

        public Cuadrado(Punto v1, int lado)
        {
            _vertice1 = v1;
            Lado = lado;
            _perimetro = 4 * lado;
            _area = lado * lado;
            _vertice2 = new Punto(v1.X + lado, v1.Y);
            _vertice3 = new Punto(v1.X + lado, v1.Y + lado);
            _vertice4 = new Punto(v1.X, v1.Y + lado);
        }

        public void DibujarCuadrado()
        {
            Console.CursorTop = Vertice1.Y;
            Console.CursorLeft = Vertice1.X;
            Console.Write("".PadLeft(Vertice2.X,'*'));
            
            for (int i = Vertice1.Y; i <= Vertice3.Y; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = Vertice1.X + Vertice2.X;
                Console.Write('*');

                Console.CursorLeft = Vertice1.X;
                Console.Write('*');

            }

            Console.CursorTop = Vertice4.Y;
            Console.CursorLeft = Vertice4.X;
            Console.Write("".PadLeft(Vertice3.X,'*'));

        }
    }
}
