using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_06_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // void Main()
            // void Main(string[] args)
            // int Main()
            // int Main(string[] args)

            int pos = 1;

            Console.WriteLine("Soy Main(), has pasado {0} parámetros", args.Length);

            foreach (string tmp in args)
            {
                Console.WriteLine("[{0}] -> {1}", pos++.ToString().PadLeft(3), tmp);
            }

            Console.ReadLine();
        }
    }
}
