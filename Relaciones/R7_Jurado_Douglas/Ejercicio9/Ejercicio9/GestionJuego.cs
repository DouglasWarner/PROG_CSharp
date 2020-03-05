using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class GestionJuego
    {
        private Random _rndPosicion;
        private int _minAnchura = 2;
        private int _minAltura = 3;
        private int _anchura = Console.WindowWidth-2;
        private int _altura = Console.WindowHeight-4;
        private string _titulo;
        private string[] _mensajeFin;
        private string[,] _areaJuego;
        private Jugador _j;
        private Tesoro _t;
        private ConsoleKey _teclaSalir;

        public GestionJuego()
        {
            _rndPosicion = new Random();

            _mensajeFin = new string[] {"".PadRight(59,'*'),
                                       "".PadRight(59,'*'),
                                       "**                                                       **",
                                       "**                   G A N A S T E S                     **",
                                       "**                                                       **",
                                       "".PadRight(59,'*'),
                                       "".PadRight(59,'*')};

            _teclaSalir = ConsoleKey.Escape;
        }

        private string[,] CrearArea()
        {
            _areaJuego = new string[_altura, _anchura];

            for (int i = 0; i < _areaJuego.GetLength(0); i++)
            {
                for (int k = 0; k < _areaJuego.GetLength(1); k++)
                {
                    _areaJuego[i, k] = " ";
                    _areaJuego[0, k] = "*";
                    _areaJuego[_altura - 1, k] = "*";
                    _areaJuego[i, 0] = "*";
                    _areaJuego[i, _anchura - 1] = "*";
                }
            }

            return _areaJuego;
        }

        private void MostrarTitulo()
        {
            _titulo = string.Format("\tJUGADOR:  X: {0}, Y: {1}      TESORO:  X: {2}, Y: {3}  {4} ESCAPE PARA SALIR", _j.PosX, _j.PosY, _t.PosX, _t.PosY, "".PadLeft(30));
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(_titulo);
        }

        private void MostrarMundo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < _areaJuego.GetLength(0); i++)
            {
                for (int k = 0; k < _areaJuego.GetLength(1); k++)
                {
                    Console.Write(_areaJuego[i,k]);
                }
                Console.WriteLine();
            }   
            Console.ResetColor();

            _j.MostrarJugador();
            _t.MostrarTesoro();
        }

        private void MostrarMensajeFin()
        {
            Console.CursorTop = 10;
            Console.CursorLeft = 30;
            for (int i = 0; i < _mensajeFin.Length; i++)
            {
                Console.CursorLeft = 30;
                Console.WriteLine(_mensajeFin[i]);
            }
            Console.ReadLine();
        }
        
        
        private void MovimientoJugador(ConsoleKeyInfo tecla)
        {
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (tecla.Modifiers == ConsoleModifiers.Control)
                {
                    if (_j.PosX < _minAltura+1)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX-=2, _j.PosY);
                }
                else
                {
                    if (_j.PosX < _minAltura)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(--_j.PosX, _j.PosY);
                }
            }
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (tecla.Modifiers == ConsoleModifiers.Control)
                {
                    if (_j.PosX >= _altura - 2)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX+=2, _j.PosY);
                }
                else
                {
                    if (_j.PosX >= _altura - 1)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(++_j.PosX, _j.PosY);
                }
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                if (tecla.Modifiers == ConsoleModifiers.Control)
                {
                    if (_j.PosY >= _anchura - 3)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX, _j.PosY+=2);
                }
                else
                {
                    if (_j.PosY >= _anchura - 2)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX, ++_j.PosY);
                }
            }
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                if (tecla.Modifiers == ConsoleModifiers.Control)
                {
                    if (_j.PosY < _minAnchura+1)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX, _j.PosY-=2);
                }
                else
                {
                    if (_j.PosY < _minAnchura)
                        return;

                    Console.SetCursorPosition(_j.PosY, _j.PosX);
                    Console.Write(" ");

                    _j.MoverJugador(_j.PosX, --_j.PosY);
                }
            }
        }
        
        private void MovimientoTesoro()
        {
            int movimientoX = _rndPosicion.Next(-1, 2);
            int movimientoY = _rndPosicion.Next(-1, 2);

            if (_t.PosX < _minAltura)
                movimientoX = _rndPosicion.Next(0, 2);
            if (_t.PosX >= _altura - 1)
                movimientoX = _rndPosicion.Next(-1, 1);
            if (_t.PosY >= _anchura - 2)
                movimientoY = _rndPosicion.Next(-1, 1);
            if (_t.PosY < _minAnchura)
                movimientoY = _rndPosicion.Next(0, 2);

            Console.SetCursorPosition(_t.PosY, _t.PosX);
            Console.Write(" ");

            _t.PosX += movimientoX;
            _t.PosY += movimientoY;
        }

        private bool Encontrado()
        {
            return _j.PosX.Equals(_t.PosX) && _j.PosY.Equals(_t.PosY);
        }

        public void Jugar()
        {
            ConsoleKeyInfo movimiento = new ConsoleKeyInfo();
            _j = new Jugador(_rndPosicion.Next(4, _altura-1), _rndPosicion.Next(2, _anchura-1));
            _t = new Tesoro(_rndPosicion.Next(4, _altura-1), _rndPosicion.Next(2, _anchura-1));

            CrearArea();
            MostrarTitulo();
            MostrarMundo();
            
            while ((movimiento = Console.ReadKey(true)).Key != _teclaSalir)
            {
                MostrarTitulo();
                MovimientoJugador(movimiento);
                MovimientoTesoro();
                _j.MostrarJugador();
                _t.MostrarTesoro();

                if (Encontrado())
                {
                    MostrarMensajeFin();
                    return;
                }
            }
        }

        
    }
}
