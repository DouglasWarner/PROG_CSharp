using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_15_01_ClasePOJO
{
    /* Para que mi clase pueda ser recorrido como si fuera una colección tenemos que implementar dos interfaces:
     *      - IEnumerator, con estos metodos:
     *              - bool MoveNext()
     *              - void Reset()
     *              - object Current{get}
     *      - IEnumerable, con este metodo:
     *              - GetEnumerator()
     */

    class ListaPersonas : IEnumerator<Persona>, IEnumerable<Persona>
    {
        private List<Persona> _listaPersona = new List<Persona>();
        private int _codigoPersona = 100;

        public ListaPersonas()
        {
            Persona p = new Persona("aazz", "ggggggggg", DateTime.Parse("01/10/2000"), 9999.99);
            p.Codigo = 9999;
            _listaPersona.Add(p);

            Persona p1 = new Persona("sssssssss", "jjjjjjjjj", DateTime.Parse("01/10/2000"), 9999.99);
            p1.Codigo = 9999;
            _listaPersona.Add(p1);
        }

        public int Cuantos
        {
            get { return _listaPersona.Count; }
        }

        public bool Anadir(string nombre, string apellido, DateTime fechaNacimiento, double salario)
        {
            Persona p = new Persona();
            p.Nombre = nombre;
            p.Apellidos = apellido;
            p.FechaNacimiento = fechaNacimiento;
            p.SueldoAnual = salario;
            p.Codigo = _codigoPersona++;

            _listaPersona.Add(p);

            return true;
        }

        public bool AnadirVarios(int cuantos)
        {
            for (int i = 0; i < cuantos; i++)
            {
                Anadir("Nombre_" + i.ToString("000"), "Apellidos_" + i.ToString("000"), DateTime.Now, 1000);
            }

            return true;
        }

        public void Listar()
        {
            foreach (var item in _listaPersona)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Ordenar()
        {
            _listaPersona.Sort();
        }

        public void OrdenarPersonas(int i)
        {
            _listaPersona.Sort(new OrdenaPorNombre());
            //_listaPersona.OrderBy(x => x.Nombre);
        }

        //---------------------
        // Inicio del FORECH
        //---------------------
        int posicion = -1;

        #region       E S T O    E S    L A    O P C I O N    D E    O B J E C T
        /*public Persona Current
        {
            get { return _listaPersona[posicion]; }
        }

        public bool MoveNext()
        {
            // Desplaza el iterador en la colleción
            // Devuelve true si se avanzo, falso si no.
            if(posicion < _listaPersona.Count - 1)
            {
                posicion++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }

        public void Reset()
        {
            posicion = -1;
        }

        public IEnumerator GetEnumerator()
        {
            // Devuelvo el objeto
            return this;
        }*/
        #endregion

        #region       E S T O    E S    L A    O P C I O N    D E    P E R S O N A
        public Persona Current
        {
            get { return _listaPersona[posicion]; }
        }

        public void Dispose()
        {
            // No hace falta
            ;
        }

        object IEnumerator.Current
        {
            // No hace falta
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            // Desplaza el iterador en la colleción
            // Devuelve true si se avanzo, falso si no.
            if (posicion < _listaPersona.Count - 1)
            {
                posicion++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }

        public IEnumerator<Persona> GetEnumerator()
        {
            // Devuelvo el objeto
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // No hace falta
            throw new NotImplementedException();
        }
        #endregion

        //-------------------
        // Fin del FORECH
        //-------------------
    }
}
