using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class MenuPrincipal
    {
        private string _titulo;
        private string[] _opciones;
        private string _mensaje;
        private Marco.Tipo _tipo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string[] Opciones
        {
            get { return _opciones; }
            set { _opciones = value; }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        /// <summary>
        /// Crea un objeto de tipo MenuPrincipal
        /// </summary>
        public MenuPrincipal()
        {

        }

        /// <summary>
        /// Crea un objeto de tipo MenuPrincipal pasandole el titulo, las opciones y el mensaje
        /// </summary>
        /// <param name="titulo">Titulo del menu</param>
        /// <param name="opcion">Las opciones a elegir del menu</param>
        /// <param name="mensaje">El mensaje de seleccionar una opcion</param>
        public MenuPrincipal(string titulo, string[] opcion, string mensaje)
        {
            Titulo = titulo;
            Opciones = opcion;
            Mensaje = mensaje;
            _tipo = Marco.Tipo.Simple;
        }

        public MenuPrincipal(string titulo, string[] opcion, string mensaje, Marco.Tipo tipo)
        {
            Titulo = titulo;
            Opciones = opcion;
            Mensaje = mensaje;
            _tipo = tipo;
        }

        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda)
        {
            int anchura = 3;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo);

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            //posInicialArriba = Console.CursorTop;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
       }

        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, ConsoleColor colorFondo)
        {
            Console.BackgroundColor = colorFondo;

            int anchura = 3;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble(colorFondo);
            else
                marco.DibujarMarcoSimple(colorFondo);

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo);

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            //posInicialArriba = Console.CursorTop;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
        }
        
        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, int anchoMenu)
        {
            int anchura = 3;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            anchura = (anchoMenu > anchura) ? anchoMenu : anchura;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo);

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            //posInicialArriba = Console.CursorTop;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
        }

        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, ConsoleColor colorFondo, ConsoleColor colorLetra)
        {
            Console.BackgroundColor = colorFondo;
            Console.ForegroundColor = colorLetra;

            int anchura = 3;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble(colorFondo);
            else
                marco.DibujarMarcoSimple(colorFondo);

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo);

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            //posInicialArriba = Console.CursorTop;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            if (_tipo == Marco.Tipo.Doble)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('╠');
                Console.Write("".PadLeft(anchura - 1, '═'));
                Console.WriteLine('╣');
            }
            else
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.Write('├');
                Console.Write("".PadLeft(anchura - 1, '─'));
                Console.WriteLine('┤');
            }

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
        }
    }
}
