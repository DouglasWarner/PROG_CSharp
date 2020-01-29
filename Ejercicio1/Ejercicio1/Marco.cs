using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Marco
    {
        public enum Tipo
        {
            Simple, Doble
        }

        private int _verticeSuperior;
        private int _verticeIzquierda;
        private int _verticeInferior;
        private int _verticeDerecha;

        public int VerticeSuperior
        {
            get { return _verticeSuperior; }
            set { _verticeSuperior = value; }
        }
        public int VerticeIzquierda
        {
            get { return _verticeIzquierda; }
            set { _verticeIzquierda = value; }
        }
        public int VerticeInferior
        {
            get { return _verticeInferior; }
            set { _verticeInferior = value; }
        }
        public int VerticeDerecha
        {
            get { return _verticeDerecha; }
            set { _verticeDerecha = value; }
        }

        public Marco()
        {}

        public Marco(int top, int izq, int inf, int dcho)
        {
            VerticeSuperior = top;
            VerticeIzquierda = izq;
            VerticeInferior = inf;
            VerticeDerecha = dcho;
        }

        /*       196
         * 218 ┌  ─  ┐ 191 
         * 179 │     │ 179 
         * 192 └  ─  ┘ 217
         *       196
         * 195 ├  ─  ┤ 180
         * -------------------------
         *       205
         * 201 ╔  ═  ╗ 187
         * 186 ║     ║ 186
         * 200 ╚  ═  ╝ 188
         *       205
         * 204 ╠  ═  ╣ 185
         */
        public void DibujarMarcoSimple()
        {
            Console.CursorTop = VerticeSuperior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('┌');
            Console.Write("".PadLeft(VerticeDerecha-1,'─'));
            Console.Write('┐');

            Console.CursorTop++;
            for (int i = 0; i <= VerticeInferior; i++)
            {
                Console.CursorLeft = VerticeIzquierda;
                Console.Write('│');
                Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
                Console.Write('│');
                Console.CursorTop++;
            }

            //Console.CursorTop++;
            //Console.CursorTop = VerticeSuperior + VerticeInferior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('└');
            Console.Write("".PadLeft(VerticeDerecha - 1, '─'));
            Console.Write('┘');
        }

        public void DibujarMarcoDoble()
        {
            Console.CursorTop = VerticeSuperior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╔');
            Console.Write("".PadLeft(VerticeDerecha - 1, '═'));
            Console.Write('╗');

            Console.CursorTop++;
            for (int i = 0; i <= VerticeInferior; i++)
            {
                Console.CursorLeft = VerticeIzquierda;
                Console.Write('║');
                Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
                Console.Write('║');
                Console.CursorTop++;
            }

            //Console.CursorTop = VerticeSuperior + VerticeInferior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╚');
            Console.Write("".PadLeft(VerticeDerecha - 1, '═'));
            Console.Write('╝');
        }

        public void DibujarMarcoSimple(ConsoleColor colorFondo)
        {
            DibujarConsola(colorFondo);

            Console.CursorTop = VerticeSuperior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('┌');
            Console.Write("".PadLeft(VerticeDerecha - 1, '─'));
            Console.Write('┐');

            Console.CursorTop++;
            for (int i = 0; i <= VerticeInferior; i++)
            {
                Console.CursorLeft = VerticeIzquierda;
                Console.Write('│');
                Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
                Console.Write('│');
                Console.CursorTop++;
            }

            //Console.CursorTop++;
            //Console.CursorTop = VerticeSuperior + VerticeInferior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('└');
            Console.Write("".PadLeft(VerticeDerecha - 1, '─'));
            Console.Write('┘');
        }

        public void DibujarMarcoDoble(ConsoleColor colorFondo)
        {
            DibujarConsola(colorFondo);

            Console.CursorTop = VerticeSuperior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╔');
            Console.Write("".PadLeft(VerticeDerecha - 1, '═'));
            Console.Write('╗');

            Console.CursorTop++;
            for (int i = 0; i <= VerticeInferior; i++)
            {
                Console.CursorLeft = VerticeIzquierda;
                Console.Write('║');
                Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
                Console.Write('║');
                Console.CursorTop++;
            }

            //Console.CursorTop = VerticeSuperior + VerticeInferior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╚');
            Console.Write("".PadLeft(VerticeDerecha - 1, '═'));
            Console.Write('╝');
        }

        private void DibujarConsola(ConsoleColor colorFondo)
        {
            Console.BackgroundColor = colorFondo;

            for (int i = 0; i <= Console.WindowHeight; i++)
            {
                Console.Write("".PadLeft(Console.WindowWidth,' '));
            }
        }
    }
}
