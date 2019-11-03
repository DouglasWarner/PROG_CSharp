using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ImprimirNVecesUnCaracter
    {
        static void Main(string[] args)
        {
            char caracter = ' ';
            int nVeces = 0;

            Console.WriteLine("Esta aplicación imprime una caracter tantas veces como se indique.");
            Console.Write("Dime el caracter: ");
            try
            {
                caracter = char.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException eANE)
            {
                Console.WriteLine(eANE.Message);
            }
            catch (FormatException eFE)
            {
                Console.WriteLine(eFE.Message);
            }

            Console.Write("\nDime el entero: ");
            try
            {
                nVeces = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException eANE)
            {
                Console.WriteLine(eANE.Message);
            }
            catch (FormatException eFE)
            {
                Console.WriteLine(eFE.Message);
            }

            Console.WriteLine("".PadLeft(nVeces,caracter));

            Console.ReadLine();
        }
    }
}
