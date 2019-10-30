using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DateTime fecha1;
            DateTime fecha2 = new DateTime(1992,10,17);

            string entrada = string.Empty;
            int anio = 0;

            Console.WriteLine("Dime un año, te digo si es bisiesto");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out anio))
            {
                try
                {
                    fecha1 = new DateTime(anio, 2, 29);
                    Console.WriteLine("Año {0} es bisiesto", fecha1.ToShortDateString());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Año {0} no es bisiesto", fecha1.ToShortDateString());
                }
            }

            Console.ReadLine();
        }
    }
}
