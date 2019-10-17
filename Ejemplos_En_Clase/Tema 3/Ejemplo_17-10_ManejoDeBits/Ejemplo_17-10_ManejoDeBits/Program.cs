using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_17_10_ManejoDeBits
{
    class ManejoDeBits
    {
        static void Main(string[] args)
        {
            // Desplazamiento de bits
            int i = 15;
            int b = 0;
            int c = 0;

            Console.WriteLine("El valor de i es: {0} --> {0:X8}", i);
            b = i >> 32;
            Console.WriteLine("El valor de b es: {0} --> {0:X8}", b);
            c = i << 1;
            Console.WriteLine("El valor de c es {0} --> {0:X8}", c);

            Console.WriteLine("\n\n");

            // Operaciones lógicas con Bits

            //      Lógica operación Y (&) de bits
            Console.WriteLine(" 0 & 0 --> {0}", 0 & 0);
            Console.WriteLine(" 0 & 1 --> {0}", 0 & 1);
            Console.WriteLine(" 1 & 0 --> {0}", 1 & 0);
            Console.WriteLine(" 1 & 1 --> {0}", 1 & 1);
            Console.WriteLine();
            //      Lógica operación O (|) de bits
            Console.WriteLine(" 0 | 0 --> {0}", 0 | 0);
            Console.WriteLine(" 0 | 1 --> {0}", 0 | 1);
            Console.WriteLine(" 1 | 0 --> {0}", 1 | 0);
            Console.WriteLine(" 1 | 1 --> {0}", 1 | 1);
            Console.WriteLine();
            //      Lógica operación O Exclusiva (^) de bits
            Console.WriteLine(" 0 ^ 0 --> {0}", 0 ^ 0);
            Console.WriteLine(" 0 ^ 1 --> {0}", 0 ^ 1);
            Console.WriteLine(" 1 ^ 0 --> {0}", 1 ^ 0);
            Console.WriteLine(" 1 ^ 1 --> {0}", 1 ^ 1);
            Console.ReadLine();
        }
    }
}
