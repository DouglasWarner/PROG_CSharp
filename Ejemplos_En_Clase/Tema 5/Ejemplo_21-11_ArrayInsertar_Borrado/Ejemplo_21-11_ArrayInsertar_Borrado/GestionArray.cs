using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_21_11_ArrayInsertar_Borrado
{
    class GestionArray
    {
        private int _nDatos = 0;
        private const int TAMANO = 100;
        private int[] _datos = null;

        /// <summary>
        /// Crea el array de enteros con el tamaño por defecto, 100.
        /// </summary>
        public GestionArray() 
        {
            this._datos = new int[TAMANO];
        }
        /// <summary>
        /// Crea el array de enteros con el tamaño que se indique
        /// </summary>
        /// <param name="t">tamaño del array</param>
        public GestionArray(int t)
        {
            this._datos = new int[t];
        }

        public void VerArray()
        {
            Console.WriteLine("     Array de enteros");
            Console.WriteLine("====================================");
            for (int i = 0; i < _nDatos; i++)
            {
                Console.Write("{0},  ", _datos[i].ToString("00"));
            }
            Console.WriteLine("\n\n\n");
        }

        public bool Insertar(int dato, int pos)
        {
            if (_nDatos == _datos.Length || pos < 0 || pos > _nDatos)
                return false;

            for (int i = _nDatos - 1; i >= pos; i--)
                _datos[i + 1] = _datos[i];
            _datos[pos] = dato;
            _nDatos++;

            return true;
        }

        public bool Borrar(int pos)
        {
            if (pos < 0 || pos > _nDatos - 1 || _nDatos == 0)
                return false;
            
            for (int i = pos; i < _nDatos - 1; i++)
            {
                _datos[i] = _datos[i + 1];
            }
            _nDatos--;

            return true;
        }

        public int Buscar(int dato)
        {
            if (_nDatos == 0)
                return -1;

            for (int i = 0; i < _nDatos-1; i++)
                if (dato == _datos[i])
                    return i;

            return -1;
        }

        #region Zona de Pruebas
        public void InsertarValores(int cuantos)
        {
            int limite = 100;
            Random rnd = new Random();
            for (int i = 0; i < cuantos; i++)
                Insertar(rnd.Next(limite), 0);
        }
        #endregion
    }
}
