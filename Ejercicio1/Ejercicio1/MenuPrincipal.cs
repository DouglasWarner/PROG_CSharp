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
        }


    }
}
