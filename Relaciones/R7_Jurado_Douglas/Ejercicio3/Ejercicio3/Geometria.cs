using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            _vertice2 = new Punto(lado, v1.Y);
            _vertice3 = new Punto(lado, v1.Y + lado);
            _vertice4 = new Punto(v1.X, v1.Y + lado);
        }

        public void DibujarCuadrado()
        {
            for (int i = Vertice1.Y; i < _vertice3.Y; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = Vertice1.X;
                for (int j = 0; j < Vertice2.X; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            /*
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
            Console.Write("".PadLeft(Vertice3.X,'*'));*/

        }

        public void DibujarAleatorio()
        {
            Random rnd = new Random();
            int posXAlea = 100;
            int posYAlea = 100;
            int posX = 0;
            int posY = 0;
            int xAlea = 10;
            int yAlea = 10;
            int cuantos = 30;
            int pausa = 500;
            ConsoleColor[] colores = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

            for (int i = 0; i < cuantos; i++)
            {
                Punto p1 = new Punto(rnd.Next(1, xAlea), rnd.Next(1, yAlea));
                Cuadrado c = new Cuadrado(p1, rnd.Next(1,xAlea));
                posX = rnd.Next(1, posXAlea);
                posY = rnd.Next(1, posYAlea);

                Console.BackgroundColor = colores[rnd.Next(colores.Length - 1)];
                for (int j = c.Vertice1.X; j <= c.Vertice3.Y; j++)
                {
                    Console.CursorTop = j;
                    Console.CursorLeft = posX;
                    for (int k = 0; k <= c.Vertice2.X; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Thread.Sleep(pausa);

            }

        }
    }
}
