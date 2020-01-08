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
            if (!_dicPersonas.ContainsKey(_dicCodigo))
                _dicPersonas.Add(_dicCodigo, persona);
            else
                return false;

            return true;
        }

        public bool BorrarPersona(int cod)
        {
            if (_dicPersonas.ContainsKey(cod))
                _dicPersonas[cod].Borrado = true;

            return true;
        }

        public void MostrarPersona(int cod)
        {
            string mensaje = string.Format("\tError: No exite la persona con código {0}", cod);

            if (_dicPersonas.ContainsKey(cod))
            {
                Console.Write(_dicPersonas[cod].Borrado ? mensaje : "\n\t"+cod.ToString() + _dicPersonas[cod].VerPersona());
            }
            else
                Console.Write(mensaje);

            Console.Write("\n\nPulsa cualquier tecla...");
            Console.ReadLine();
        }

        public void MostrarListado()
        {
            foreach (KeyValuePair<int,Personas> item in _dicPersonas)
            {
                Console.WriteLine("\n\t{0}\t{1}", item.Key, item.Value.VerPersona());
            }

            Console.Write("\nPulsa cualquier tecla...");
            Console.ReadLine();
        }
    }
}
