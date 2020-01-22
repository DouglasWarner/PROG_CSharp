using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Marco
    {
        enum Tipo
        {
            Simple, Doble
        }

        private ConsoleColor _color;
        private int _verticeSuperior;
        private int _verticeIzquierda;
        private int _verticeInferior;
        private int _verticeDerecha;

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
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

        public Marco(int top, int izq, int inf, int dcho, ConsoleColor color)
        {
            VerticeSuperior = top;
            VerticeIzquierda = izq;
            VerticeInferior = inf;
            VerticeDerecha = dcho;
            Color = color;
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
        public void DibujarMarco()
        {
            Console.CursorTop = VerticeSuperior;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('┌');
            for (int i = 0; i < VerticeDerecha-1; i++)
            {
                Console.Write('─');
            }
            Console.Write('┐');

            Console.CursorTop++;
            for (int i = 0; i < VerticeInferior-1; i++)
            {
                Console.CursorLeft = VerticeIzquierda;
                Console.Write('│');
                Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
                Console.Write('│');
                Console.CursorTop++;
            }
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('└');
            Console.CursorLeft = VerticeIzquierda + VerticeDerecha;
            Console.Write('┘');

            Console.CursorTop = VerticeSuperior + VerticeInferior;
            Console.Write('└');
            for (int i = 0; i < VerticeDerecha - 1; i++)
            {
                Console.Write('─');
            }
            Console.Write('┘');
        }
    }
}
