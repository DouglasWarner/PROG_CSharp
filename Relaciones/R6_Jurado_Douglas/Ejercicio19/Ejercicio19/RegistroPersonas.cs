using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class RegistroPersonas
    {
        private int _dicCodigo = 1000;
        private Dictionary<int, Personas> _dicPersonas = new Dictionary<int, Personas>();

        public RegistroPersonas()
        { }

        public bool AnadirPersona(Personas persona)
        {
            _dicPersonas.Add(_dicCodigo++, persona);

            return true;
        }

        public bool BorrarPersona(int cod)
        {
            if (_dicPersonas.ContainsKey(cod))
                _dicPersonas[cod].Borrado = true;

            return true;
        }

        public bool MostrarPersona(int cod)
        {
            string mensaje = string.Format("\tError: No exite la persona con código {0}", cod);

            if (_dicPersonas.ContainsKey(cod))
            {
                if (_dicPersonas[cod].Borrado)
                {
                    Console.WriteLine(mensaje);
                    return false;
                }
                else
                {
                    Console.WriteLine("\n\t" + cod.ToString() + _dicPersonas[cod].VerPersona());
                    return true;
                }
            }
            else
            {
                Console.Write(mensaje);
                Console.Write("\n\nPulsa cualquier tecla...");
                Console.ReadLine();
                return false;
            }
        }

        public bool BuscarPersona(int cod)
        {
            string mensaje = string.Format("\tError: No exite la persona con código {0}", cod);

            if (_dicPersonas.ContainsKey(cod))
            {
                if (_dicPersonas[cod].Borrado)
                {
                    Console.WriteLine(mensaje);
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Write(mensaje);
                Console.Write("\n\nPulsa cualquier tecla...");
                Console.ReadLine();
                return false;
            }
        }

        public void MostrarListado()
        {
            Console.WriteLine("\tLista de Personas");
            Console.WriteLine("".PadLeft(40,'-'));
            foreach (KeyValuePair<int,Personas> item in _dicPersonas)
            {
                if(!item.Value.Borrado)
                    Console.WriteLine("\n\t{0}   {1}", item.Key, item.Value.VerPersona());
            }

            Console.Write("\n\nPulsa cualquier tecla...");
            Console.ReadLine();
        }

        public bool ModificarPersona(int codigo)
        {
            if (!BuscarPersona(codigo))
               return false;

            Console.Write(" Dime el nombre: ");
            _dicPersonas[codigo].Nombre = Console.ReadLine();
            Console.Write(" Dime los apellidos: ");
            _dicPersonas[codigo].Apellidos = Console.ReadLine();
            Console.Write(" Dime el telefono: ");
            _dicPersonas[codigo].Telefono = Console.ReadLine();

            return true;
        }
    }
}
