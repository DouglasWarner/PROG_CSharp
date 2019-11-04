using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class CalcularMedia
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double sumatoria = 0;
            double nCantidad = 0;
            Console.WriteLine("Esta aplicación cálcula la media de la serie de números introducidos.");
            Console.WriteLine("Introduce los números.");

            do
            {
                try
                {
                    nCantidad++;
                    numero = double.Parse(Console.ReadLine());
                    sumatoria += numero;

                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    return;
                }
            }
            while (numero != 0);

            Console.WriteLine("La media de los números introducidos: {0:F}", sumatoria / nCantidad);
            Console.ReadLine();
        }
    }
}
