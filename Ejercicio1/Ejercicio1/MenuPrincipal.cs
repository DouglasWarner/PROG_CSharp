using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejercicio1
{
    sealed class ValoresNulosException : Exception
    {
        public ValoresNulosException(string mensaje) : base (mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    /// <summary>
    /// Clase que muestra un menu
    /// </summary>
    public class MenuPrincipal
    {
        private string _titulo;
        private string[] _opciones;
        private string _mensaje;
        private Marco.Tipo _tipo;

        /// <summary>
        /// Asigna y devuelve el titulo a mostrar en el menu
        /// </summary>
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        /// <summary>
        /// Asigna y devuelve el contenido del menu
        /// </summary>
        public string[] Opciones
        {
            get { return _opciones; }
            set { _opciones = value; }
        }
        /// <summary>
        /// Asigna y devuelve el mensaje final del menu
        /// </summary>
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
        /// <param name="opcion">El contenido a elegir del menu</param>
        /// <param name="mensaje">El mensaje de seleccionar una opcion</param>
        public MenuPrincipal(string titulo, string[] opcion, string mensaje)
        {
            Titulo = titulo;
            Opciones = opcion;
            Mensaje = mensaje;
            _tipo = Marco.Tipo.Simple;
        }
        /// <summary>
        /// Muestra el menu creado.
        /// </summary>
        /// <param name="tipo">El tipo del marco, simple o doble.</param>
        public void MostrarMenu(Marco.Tipo tipo)
        {
            if (Titulo == null || Opciones == null || Mensaje == null)
                throw new ValoresNulosException("Error: Porfavor asigna el titulo, el contenido y el mensaje.");

            int posDefecto = 25;
            int anchura = 10;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posDefecto, posDefecto, altura, anchura);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(posDefecto + 1, posDefecto + 1);
            Console.WriteLine(Titulo.PadLeft(Titulo.Length + 5));
            Console.CursorTop++;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posDefecto + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            Console.CursorTop++;
            Console.CursorLeft = posDefecto + 1;
            Console.Write(Mensaje);
        }
        /// <summary>
        /// Muestra el menu creado.
        /// </summary>
        /// <param name="posInicialArriba">posicion inicial superior</param>
        /// <param name="posInicialIzquierda">posicion inicial izquierda</param>
        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda)
        {
            if (Titulo == null || Opciones == null || Mensaje == null)
                throw new ValoresNulosException("Error: Porfavor asigna el titulo, el contenido y el mensaje.");

            int anchura = 10;
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
            Console.WriteLine(Titulo.PadLeft(Titulo.Length+5));
            Console.CursorTop++;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            Console.CursorTop++;
            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
       }
        /// <summary>
        /// Muestra el menu creado.
        /// </summary>
        /// <param name="posInicialArriba">posicion inicial superior</param>
        /// <param name="posInicialIzquierda">posicion inicial izquierda</param>
        /// <param name="colorFondo">El color que se va a pintar la consola</param>
        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, ConsoleColor colorFondo)
        {
            if (Titulo == null || Opciones == null || Mensaje == null)
                throw new ValoresNulosException("Error: Porfavor asigna el titulo, el contenido y el mensaje.");

            int anchura = 10;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            marco.DibujarConsola(colorFondo);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo.PadLeft(Titulo.Length + 5));

            Console.CursorTop++;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            Console.CursorTop++;

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);

            Console.ResetColor();
        }
        /// <summary>
        /// Muestra el menu creado.
        /// </summary>
        /// <param name="posInicialArriba">posicion inicial superior</param>
        /// <param name="posInicialIzquierda">posicion inicial izquierda</param>
        /// <param name="anchoMenu">El ancho de menu</param>
        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, int anchoMenu)
        {
            if (Titulo == null || Opciones == null || Mensaje == null)
                throw new ValoresNulosException("Error: Porfavor asigna el titulo, el contenido y el mensaje.");

            int anchura = 10;
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
            Console.WriteLine(Titulo.PadLeft(Titulo.Length + 5));

            Console.CursorTop++;

            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            Console.CursorTop++;

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);
        }
        /// <summary>
        /// Muestra el menu creado.
        /// </summary>
        /// <param name="posInicialArriba">posicion inicial superior</param>
        /// <param name="posInicialIzquierda">posicion inicial izquierda</param>
        /// <param name="colorFondo">El color que se va a pintar la consola</param>
        /// <param name="colorLetra">El color que se va a pintar las letras</param>
        public void MostrarMenu(int posInicialArriba, int posInicialIzquierda, ConsoleColor colorFondo, ConsoleColor colorLetra)
        {
            if (Titulo == null || Opciones == null || Mensaje == null)
                throw new ValoresNulosException("Error: Porfavor asigna el titulo, el contenido y el mensaje.");

            Console.ForegroundColor = colorLetra;

            int anchura = 10;
            int altura = Opciones.Length + 3;
            int longitudMaxOpciones = Opciones.Max(x => x.Length);

            if (longitudMaxOpciones > Titulo.Length && longitudMaxOpciones > Mensaje.Length)
                anchura += longitudMaxOpciones;
            else if (Mensaje.Length > Titulo.Length)
                anchura += Mensaje.Length;
            else
                anchura += Titulo.Length;

            Marco marco = new Marco(posInicialArriba, posInicialIzquierda, altura, anchura);

            marco.DibujarConsola(colorFondo);

            if (_tipo == Marco.Tipo.Doble)
                marco.DibujarMarcoDoble();
            else
                marco.DibujarMarcoSimple();

            Console.SetCursorPosition(posInicialIzquierda + 1, posInicialArriba + 1);
            Console.WriteLine(Titulo.PadLeft(Titulo.Length + 5));

            Console.CursorTop++;
            
            for (int i = 0; i < Opciones.Length; i++)
            {
                Console.CursorLeft = posInicialIzquierda + 1;
                Console.WriteLine(Opciones[i].PadLeft(longitudMaxOpciones));
            }

            Console.CursorTop++;

            Console.CursorLeft = posInicialIzquierda + 1;
            Console.Write(Mensaje);

            Console.ResetColor();
        }
    }
}
