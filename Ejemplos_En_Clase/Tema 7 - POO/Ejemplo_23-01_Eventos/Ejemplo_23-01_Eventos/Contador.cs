using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejemplo_23_01_Eventos
{
    delegate void DlgCambioContador(int i);

    class Contador
    {
        public event DlgCambioContador evtCambioContador;
        private int _contador;
        private int _fin;
        private bool _iniciar;
        private bool _conColores;
        private bool _conPosicionAlea;
        private int _izq = 10;
        private int _arriba = 10;
        private int _retardo = 500;
        private ConsoleColor[] _colores = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        /// <summary>
        /// Crea un contador de 0 hasta 100 sin empezar.
        /// </summary>
        public Contador()
        {
            _contador = 0;
            _fin = 100;
            _iniciar = false;
            _conPosicionAlea = false;
            _conColores = false;
        }
        /// <summary>
        /// Inicializa el contador o lo pausa.
        /// </summary>
        public bool Iniciar
        {
            get { return _iniciar; }
            set { _iniciar = value; }
        }
        /// <summary>
        /// Devuelve el valor por el que se encuentra el contador.
        /// </summary>
        public int Contador1
        {
            get { return _contador; }
        }
        /// <summary>
        /// Establece el final del contador.
        /// </summary>
        public int Fin
        {
            get { return _fin; }
            set { _fin = value; }
        }
        /// <summary>
        /// Activador para mostrarlo con colores aleatorios
        /// </summary>
        public bool ConColores
        {
            get { return _conColores; }
            set { _conColores = value; }
        }
        /// <summary>
        /// Activador para mostrarlo en posiciones aleatorios
        /// </summary>
        public bool ConPosicionAlea
        {
            get { return _conPosicionAlea; }
            set { _conPosicionAlea = value; }
        }

        /// <summary>
        /// Método que mueve el contador.
        /// </summary>
        public void Contar()
        {
            Random rnd = new Random();

            if (!_iniciar)
                return;
            for (int i = 0; i <= _fin; i++)
            {
                Thread.Sleep(_retardo);

                if (ConColores)
                    Console.ForegroundColor = MostrarAleatorioColores(rnd);
                if (ConPosicionAlea)
                {
                    Console.Clear();
                    _izq = rnd.Next(Console.WindowWidth);
                    _arriba = rnd.Next(Console.WindowHeight);
                }

                Console.SetCursorPosition(_izq, _arriba);
                _contador++;
                if (evtCambioContador != null)
                    evtCambioContador(_contador);
            }
        }

        private ConsoleColor MostrarAleatorioColores(Random rnd)
        {
            return _colores[rnd.Next(_colores.Length)];
        }

    }
}
