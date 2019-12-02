using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConvertirTexto(5));

            Console.ReadLine();
        }

        static string ConvertirTexto(int n)
        {
            string[] numeros = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Sieste", "Ocho", "Nueve", "Diez" };

            return numeros[n];
        }
    }
}
