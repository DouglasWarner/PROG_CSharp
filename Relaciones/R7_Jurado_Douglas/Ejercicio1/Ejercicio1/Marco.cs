﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejercicio1
{
    /// <summary>
    /// El tipo del marco, simple o doble.
    /// </summary>
    public enum Tipo
    {
        /// <summary>
        /// Tipo simple
        /// </summary>
        Simple,
        /// <summary>
        /// Tipo doble
        /// </summary>
        Doble
    }

    /// <summary>
    /// Clase que dibuja un marco
    /// </summary>
    internal class Marco
    {
        
        private int _verticeSuperior;
        private int _verticeIzquierda;
        private int _verticeInferior;
        private int _verticeDerecha;
        /// <summary>
        /// Asigna o devuelve el vertice superior del marco
        /// </summary>
        public int VerticeSuperior
        {
            get { return _verticeSuperior; }
            set { _verticeSuperior = value; }
        }
        /// <summary>
        /// Asigna o devuelve el vertice izquierda del marco
        /// </summary>
        public int VerticeIzquierda
        {
            get { return _verticeIzquierda; }
            set {
                if (value > Console.WindowWidth/2)
                    throw new Exception("Error: La posición izquierda inicial debe ser menor que la mitad del ancho de la consola");
                _verticeIzquierda = value; }
        }
        /// <summary>
        /// Asigna o devuelve el vertice inferior del marco
        /// </summary>
        public int VerticeInferior
        {
            get { return _verticeInferior; }
            set { _verticeInferior = value; }
        }
        /// <summary>
        /// Asigna o devuelve el vertice derecha del marco
        /// </summary>
        public int VerticeDerecha
        {
            get { return _verticeDerecha; }
            set
            {
                if (value >= Console.WindowWidth)
                    value = (Console.WindowWidth - VerticeIzquierda) - 2;
                _verticeDerecha = value;
            }
        }
        /// <summary>
        /// Crea una instancia de objeto Marco
        /// </summary>
        public Marco()
        {}
        /// <summary>
        /// Crea una instancia de objeto Marco.
        /// </summary>
        /// <param name="top">El vertice superior</param>
        /// <param name="izq">el vertice izquierda</param>
        /// <param name="inf">vertice inferior</param>
        /// <param name="dcho">el vertice derecha</param>
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
         /// <summary>
         /// Dibuja el marco de tipo simple
         /// </summary>
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

            VerticeInferior = Console.CursorTop;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('└');
            Console.Write("".PadLeft(VerticeDerecha - 1, '─'));
            Console.Write('┘');

            Console.CursorTop = VerticeSuperior + 2;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('├' + "".PadLeft(VerticeDerecha - 1, '─') + '┤');

            Console.CursorTop = VerticeInferior - 2;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('├' + "".PadLeft(VerticeDerecha - 1, '─') + '┤');
        }
        /// <summary>
        /// Dibuja el marco de tipo doble
        /// </summary>
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

            VerticeInferior = Console.CursorTop;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╚');
            Console.Write("".PadLeft(VerticeDerecha - 1, '═'));
            Console.Write('╝');

            Console.CursorTop = VerticeSuperior + 2;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╠' + "".PadLeft(VerticeDerecha - 1, '═') + '╣');

            Console.CursorTop = VerticeInferior - 2;
            Console.CursorLeft = VerticeIzquierda;
            Console.Write('╠' + "".PadLeft(VerticeDerecha - 1, '═') + '╣');
        }
        /// <summary>
        /// Dibuja la consola de un color.
        /// </summary>
        /// <param name="colorFondo"></param>
        public void DibujarConsola(ConsoleColor colorFondo)
        {
            Console.BackgroundColor = colorFondo;

            for (int i = 0; i <= Console.WindowHeight; i++)
            {
                Console.Write("".PadLeft(Console.WindowWidth,' '));
            }
        }
    }
}
