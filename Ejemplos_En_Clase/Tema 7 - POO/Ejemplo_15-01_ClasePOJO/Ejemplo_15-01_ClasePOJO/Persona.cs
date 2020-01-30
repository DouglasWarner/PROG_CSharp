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

        private int _codigo;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private double _sueldoAnual;

        #endregion

        #region Constructores

        /// <summary>
        /// Crea un objeto de tipo Persona
        /// </summary>
        public Persona() { }
        /// <summary>
        /// Crea un objeto de tipo Persona
        /// </summary>
        /// <param name="nom">Nombre de la persona.</param>
        /// <param name="ape">Apellidos de la persona.</param>
        /// <param name="fn">Fecha de nacimiento.</param>
        /// <param name="sa">Sueldo anual.</param>
        public Persona(string nom, string ape, DateTime fn, double sa)
        {
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
        /// <summary>
        /// Asigna y devuelve el nombre de la persona actual
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                int maxLong = 30;
                _nombre = (value.Length > maxLong) ? value.Substring(0, maxLong) : value;
            }
        }
        /// <summary>
        /// Asigna y devuelve los apellidos de la persona actual
        /// </summary>
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        /// <summary>
        /// Asigna y devuelve la fecha de nacimiento de la persona actual
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { 
                _fechaNacimiento = (value > DateTime.Now) ? value.Subtract(value - DateTime.Now) : value; 
                }
        }
        /// <summary>
        /// Asigna y devuelve el sueldo anual de la persona actual
        /// </summary>
        public double SueldoAnual
        {
            get { return _sueldoAnual; }
            set { _sueldoAnual = value; }
        }

        #endregion
    }
}
