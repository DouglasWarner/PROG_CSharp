using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_16_01_RandomSinRep
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomSR rsr = new RandomSR();
            List<int> numerosUnicos = new List<int>();

            for (int i = 0; i < 18; i++)
            {
                numerosUnicos.Add(rsr.Siguiente(1, 50000));
            }

            numerosUnicos.Sort();
            foreach (int tmp in numerosUnicos)
            {
                Console.Write("{0} ", tmp);
            }

            Console.ReadLine();
        }
    }
}
