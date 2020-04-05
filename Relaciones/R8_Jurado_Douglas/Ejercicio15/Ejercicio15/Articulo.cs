using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    [Serializable]
    class Articulo
    {
        private static int _cod = 0;
        private int _codigo;
        private string _nombreArticulo;
        private float _precio;
        private float _pvp;
        private int _existencias;
        private string _comentario;
        private bool _borrado;
        // ETC

        public Articulo()
        {

        }
        public Articulo(string nombre, float precio, int existencias, string comentario)
        {
            _codigo = ++_cod;
            NombreArticulo = nombre;
            Precio = precio;
            _pvp = (Precio * 0.25F);
            Existencias = existencias;
            Comentario = comentario;
            Borrado = false;
        }

        public int Codigo
        {
            get { return _codigo; }
        }

        public string NombreArticulo
        {
            get { return _nombreArticulo; }
            set
            {
                if (value.Length > 15)
                    value = value.Substring(0, 15);
                _nombreArticulo = value;
            }
        }
        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public float Pvp
        {
            get { return _pvp; }
        }
        public int Existencias
        {
            get { return _existencias; }
            set { _existencias = value; }
        }
        public string Comentario
        {
            get { return _comentario; }
            set
            {
                if (value.Length > 50)
                    value = value.Substring(0, 50);
                _comentario = value;
            }
        }
        public bool Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public void MostrarArticuloConComentario()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("\nComentario");
            Console.WriteLine("".PadLeft(Comentario.Length,'-'));
            Console.WriteLine(Comentario);
        }

        public override string ToString()
        {
            string sep = "|";
            return sep + _nombreArticulo.PadRight(30) + 
                   sep + _precio.ToString("C", CultureInfo.GetCultureInfo("es-ES")).PadRight(20) + 
                   sep + _pvp.ToString("C", CultureInfo.GetCultureInfo("es-ES")).PadRight(10) +
                   sep + _existencias.ToString().PadLeft(10) + sep;
        }
    }
}
