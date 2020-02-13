using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Vehiculo
    {
        public enum TipoTraccion
        {
            Trasera,
            Delantera,
            Total
        }
        private string _nombre;
        private int _numeroRuedas;
        private ConsoleColor _color;
        private TipoTraccion _tipo;

        public string Nombre
        {
            get { return _nombre; }
        }
        public int NumeroRuedas
        {
            get { return _numeroRuedas; }
        }
        public ConsoleColor Color
        {
            get { return _color; }
        }
        public TipoTraccion Tipo
        {
            get { return _tipo; }
        }

        public Vehiculo(){}

        public Vehiculo(string nom, int nRuedas, ConsoleColor c, TipoTraccion t)
        {
            _nombre = nom;
            _numeroRuedas = nRuedas;
            _color = c;
            _tipo = t;
        }
        
        public override string ToString()
        {
            string separador = " ; ";
            return "[" +this.GetType().Name + "] " + "Nombre: " + Nombre + separador 
                                                   + "Ruedas: " + NumeroRuedas + separador 
                                                   + "Color: " + Color.ToString() + separador 
                                                   + "Tracción: " + Tipo.ToString();
        }
    }
}
