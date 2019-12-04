using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class GestionEmpleado
    {
        public struct Empleado
        {
            private string _apellidos;
            private string _nombre;
            private int _edad;
            private double _sueldo;
            private DateTime _fechaContrato;
            private bool _borrado;

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
            public void setBorrado(bool value)
            {
                this._borrado = value;
            }
            public bool getBorrado()
            {
                return this._borrado;
            }

            public Empleado(string nom, string ape, int edad, double sueldo, string fecha)
            {
                this._nombre = nom;
                this._apellidos = ape;
                this._edad = edad;
                this._sueldo = sueldo;
                this._fechaContrato = DateTime.Parse(fecha);
                this._borrado = false;
            }

            public override string ToString()
            {
                return getNombre().PadLeft(10) + getApellidos().PadLeft(10) + getEdad().ToString().PadLeft(5) + getSueldo().ToString().PadLeft(10) + getFechaContrato().ToShortDateString().PadLeft(20);
            }

        }
        const int TAMANO = 10;
        Empleado[] _empleado;
        int _nDatosEmp = 0;

        public GestionEmpleado() 
        {
            this._empleado = new Empleado[TAMANO];
        }

        public GestionEmpleado(int nEmp)
        {
            this._empleado = new Empleado[nEmp];
        }

        public bool Anadir(Empleado emp)
        {
            if (_nDatosEmp > _empleado.Length-1)
                return false;
            
            this._empleado[_nDatosEmp++] = emp;

            return true;
        }

        public int Buscar(int pos)
        {
            if (pos < 0 || pos > this._nDatosEmp)
                return -1;
            if (this._empleado[pos].getBorrado())
                return -1;

            return pos;
        }

        public bool Borrar(int pos)
        {
            if (Buscar(pos) == -1)
                return false;

            this._empleado[pos].setBorrado(true);

            return true;
        }

        public void Listar()
        {
            for (int i = 1; i < _nDatosEmp; i++)
            {
                if(!(this._empleado[i].getBorrado()))
                    Console.WriteLine(this._empleado[i]);
            }
        }
    }
}
