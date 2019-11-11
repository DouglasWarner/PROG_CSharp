using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_11_11_Struct
{
    struct Libro
    {
        [Flags]
        public enum Genero
        {
            Acción = 1,
            Suspense = 2,
            Drama = 4,
            Comedia = 8,
            Terror = 16
        }

        static int _index = 0;
        private int _indice;
        private string _titulo;
        private string _isbn;
        private float _pvp;
        private DateTime _fechaPub;
        private Genero _genero;

        public Libro(string titulo, string isbn, float pvp, DateTime fecha, Genero genero)
        {
            _index++;
            _indice = _index;
            _titulo = titulo;
            _isbn = isbn;
            _pvp = pvp;
            _fechaPub = fecha;
            _genero = genero;
        }

        public Libro(string titulo, string isbn, float pvp, DateTime fecha, Genero genero, Genero genero2)
        {
            _index++;
            _indice = _index;
            _titulo = titulo;
            _isbn = isbn;
            _pvp = pvp;
            _fechaPub = fecha;
            _genero = genero | genero2;
        }

        public string getTitulo()
        {
            return _titulo;
        }
        public bool CambiarTitulo(string nuevoTitulo)
        {
            if (nuevoTitulo.Length > 4)
                _titulo = nuevoTitulo;
            else
                return false;

            return true;
        }
        public string getIsbn()
        {
            return _isbn;
        }
        public string getPvp()
        {
            return string.Format("{0:F} {1}", _pvp, (char)36);
        }
        public string getFecha()
        {
            return _fechaPub.ToLongDateString();
        }
        public string getGenero()
        {
            return _genero.ToString();
        }
        public bool AnadirGenero(Genero nuevoGenero)
        {
            if (nuevoGenero == _genero)
                return false;
            else
                _genero |= nuevoGenero;

            return true;
        }

        public void Ver()
        {
            Console.WriteLine("\n          Datos del libro");
            Console.WriteLine("".PadLeft(40,'*'));
            Console.WriteLine("            Indice: " + _indice);
            Console.WriteLine("            Título: " + getTitulo());
            Console.WriteLine("              ISBN: " + getIsbn());
            Console.WriteLine("               PVP: " + getPvp());
            Console.WriteLine(" Fecha publicación: " + getFecha());
            Console.WriteLine("            Genero: " + getGenero());
        }

    }

    class MiClase
    {
        static void Main(string[] args)
        {
            Libro unLibro = new Libro("Don Quijote", "235568442", 20F, DateTime.Parse("11-11-1730"), Libro.Genero.Acción);

            unLibro.Ver();


            unLibro.CambiarTitulo("Vamos a bailar un tremendo kumbion");
            unLibro.AnadirGenero(Libro.Genero.Terror);
            unLibro.Ver();

            Libro otroLibro = new Libro("El camino hacia el dominio de C#", "235568442", 100, DateTime.Parse("12-12-2020"), Libro.Genero.Suspense, Libro.Genero.Terror);
            otroLibro.Ver();
            Console.ReadLine();
        }
    }
}
