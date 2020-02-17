using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_10_02_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICloneable[] cosas = new ICloneable[10];
            cosas[0] = new Pila();
            cosas[1] = new Factura();
            cosas[2] = new Pila();
            cosas[3] = new Factura();
            Factura f = new Factura();
            Pila p = new Pila();


            foreach (var item in cosas)
            {
                Copiar(item);
            }


            Console.ReadLine();
        }

        // Sin interface
        static void Copiar(object o)
        {
            if (o is Pila)
            {
                ((Pila)o).Clonar();
            }
            if (o is Factura)
            {
                ((Factura)o).Clonar();
            }
        }

        // Con interface
        static void Copiar(ICloneable o)
        {
            if(o != null)
                o.Clonar();
        }
    }

    class Factura : ICloneable
    {
        public void Clonar()
        {
            Console.WriteLine("Soy Factura.Clonar()");
        }
    }

    class Pila : ICloneable
    {
        public void Clonar()
        {
            Console.WriteLine("Soy Pila.Clonar()");
        }
    }

    class Dibuja : ILapiz, IBrocha
    {
        void ILapiz.Pinta()
        {
            throw new NotImplementedException();
        }

        void IBrocha.Pinta()
        {
            throw new NotImplementedException();
        }
    }
}
