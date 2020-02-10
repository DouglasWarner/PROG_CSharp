using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_15_01_ClasePOJO
{
    interface IPlano
    {
        int Alto { get; set; }
        int Ancho { get; set; }
        int X { get; set; }
        int Y { get; set; }
        void Pinta();
        void Pinta(int x, int y, int ancho, int alto);
        // Etc...
    }

    class Dibuja : IPlano
    {

        public int Alto
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Ancho
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int X
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Y
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Pinta()
        {
            throw new NotImplementedException();
        }

        public void Pinta(int x, int y, int ancho, int alto)
        {
            throw new NotImplementedException();
        }
    }
}
