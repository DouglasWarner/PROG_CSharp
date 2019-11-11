using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_07_11_Object
{
    class Program
    {
        static int numero = 3;

        static void Main(string[] args)
        {
            //  object o;
            //      Métodos estaticos de herencia de OBJECT
            //  o.Equals
            //  o.ToString
            //  o.GetType
            //  o.GetHashCode

            object e = new EventArgs();
            miClass miclase = new miClass();

            Console.WriteLine(e.GetType());
            Console.WriteLine(e);
            Console.WriteLine(e.Equals(miclase));

            Console.ReadLine();
        }
    }

    class miClass
    { }
}
