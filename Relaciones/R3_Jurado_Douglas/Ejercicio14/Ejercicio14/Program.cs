using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class FormatoDeSalida
    {
        static void Main(string[] args)
        {
            float s1 = 2.5F;
            int s2 = 25;
            int s3 = 250;
            int s4 = 250000;

            Console.WriteLine("Voy a mostrar dado un valor Integer, distintos tipos de formatos de salida con el método Write.");
            Console.WriteLine("".PadLeft(60,'-'));

            Console.WriteLine("{0:D5}", s2);
            Console.WriteLine("{0:E}", s4);
            Console.WriteLine("{0:N}", s2);
            Console.WriteLine("{0:G}", s2);
            Console.WriteLine("{0}", s1);
            Console.WriteLine("{0:N2}", s4);
            Console.WriteLine("{0:X}", s3);
            Console.ReadLine();
        }
    }
}
