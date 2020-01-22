using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejemplo_16_01_RandomSinRep;

namespace Ejemplo_16_01_UsoDLL
{
    class Program
    {
        static void Main(string[] args)
        {

            RandomSR alea = new RandomSR();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}, \t", alea.Siguiente(100, 500));
            }

            Console.ReadLine();
        }
    }
}
