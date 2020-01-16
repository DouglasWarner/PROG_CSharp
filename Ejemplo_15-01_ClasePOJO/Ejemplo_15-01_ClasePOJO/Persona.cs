using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_15_01_ClasePOJO
{
    class Persona
    {
        #region Datos Persona
        //static int _contadorCodigo;
        int _codigo;
        string _nombre;
        string _apellidos;
        DateTime _fechaNacimiento;
        double _sueldoAnual;
        #endregion

        #region Constructores
        public Persona() { }
        /// <summary>
        /// Crea un objeto de tipo Persona
        /// </summary>
        /// <param name="cod">Codigo unico de la persona.</param>
        /// <param name="nom">Nombre de la persona.</param>
        /// <param name="ape">Apellidos de la persona.</param>
        /// <param name="fn">Fecha de nacimiento.</param>
        /// <param name="sa">Sueldo anual.</param>
        public Persona(int cod, string nom, string ape, DateTime fn, double sa)
        {
            _codigo = cod;
            Nombre = nom;
            Apellidos = ape;
            FechaNacimiento = fn;
            SueldoAnual = sa;
        }
        #endregion

        #region Metodos Publicos
        public override string ToString()
        {
            string sep = ";";
            return Codigo.ToString().PadLeft(5) + sep +
                    Nombre.PadLeft(10) + sep +
                    Apellidos.PadLeft(10) + sep +
                    FechaNacimiento.ToShortDateString().PadLeft(15) + sep + 
                    SueldoAnual.ToString().PadLeft(10);
        }

        public void Saluda()
        {
            Console.WriteLine("hola");
        }
        #endregion

        #region Propiedades
        
        public int Dia { get; set; }
        /// <summary>
        /// Obtiene el codigo de la persona.
        /// </summary>
        public int Codigo
        {
            get { return _codigo; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                int maxLong = 30;
                _nombre = (value.Length > maxLong) ? value.Substring(0, maxLong) : value;
            }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { 
                _fechaNacimiento = (value > DateTime.Now) ? value.Subtract(value - DateTime.Now) : value; 
                }
        }
        public double SueldoAnual
        {
            get { return _sueldoAnual; }
            set { _sueldoAnual = value; }
        }
        #endregion
    }
}
