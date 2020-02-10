using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_15_01_ClasePOJO
{
    public class Persona : IComparable<Persona>
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
            string sep = "  ;  ";
            return Codigo.ToString().PadLeft(15) + sep +
                    Nombre.PadLeft(15) + sep +
                    Apellidos.PadLeft(15) + sep +
                    FechaNacimiento.ToShortDateString().PadLeft(15) + sep + 
                    SueldoAnual.ToString().PadLeft(10);
        }

        public override bool Equals(object obj)
        {
            return this.Codigo == ((Persona)obj).Codigo && this.Nombre.Equals(((Persona)obj).Nombre);
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
            set { _codigo = value; }
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

        public int CompareTo(Persona other)
        {
            //return String.Compare(this.Nombre, other.Nombre);

            //  Comparar por C O D I G O
            // Establece el criterio para ordenar las personas
            // Ordena por: Codigo
            
            if (this.Codigo == other.Codigo) // Iguales
                return 0;  
            if (this.Codigo > other.Codigo) // Mayor que
                return 1;   
            return -1;
        }
    }

    // Para multiples campos de ordenación
    public class OrdenaPorNombre : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            return string.Compare(x.Nombre, y.Nombre);
        }
    }

    public class OrdenaPorApellido : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            return string.Compare(x.Apellidos, y.Apellidos);
        }
    }
}
