using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class GestionEmpleado
    {
        struct Empleado
        {
            private string _apellidos;
            private string _nombre;
            private int _edad;
            private double _sueldo;
            private DateTime _fechaContrato;

            public string getNombre()
            {
                return this._nombre;
            }
            public string getApellidos()
            {
                return this._apellidos;
            }
            public int getEdad()
            {
                return this._edad;
            }
            public double getSueldo()
            {
                return this._sueldo;
            }
            public DateTime getFechaContrato()
            {
                return this._fechaContrato;
            }

            public Empleado(string nom, string ape, int edad, double sueldo, string fecha)
            {
                this._nombre = nom;
                this._apellidos = ape;
                this._edad = edad;
                this._sueldo = sueldo;
                this._fechaContrato = DateTime.Parse(fecha);
            }

            public override string ToString()
            {
                return getNombre().PadLeft(10) + getApellidos().PadLeft(10) + getEdad().ToString().PadLeft(5) + getSueldo().ToString().PadLeft(10) + getFechaContrato().ToShortDateString().PadLeft(20);
            }

        }

        Empleado[] _empleado = new Empleado[10];
        int _nDatosEmp = 0;

        public GestionEmpleado() { }

        public GestionEmpleado(Empleado emp)
        {
            _empleado[_nDatosEmp] = emp;
        }
    }
}
