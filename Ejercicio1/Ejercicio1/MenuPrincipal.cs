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
            int posDerecha = 0;
            int posArriba = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                posDerecha = longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                posDerecha = Mensaje.Length;
            else
                posDerecha = Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, posArriba, posDerecha);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(++posInicialIzquierda, ++posInicialArriba);
            Console.WriteLine(Titulo);

            posInicialArriba = Console.CursorTop;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda;
                Console.WriteLine(Opciones[i].PadLeft(Opciones.Max(x => x.Length)));
            }

            Console.CursorLeft = posInicialIzquierda;
            Console.Write(Mensaje);
       }
    }
}
