using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_CalcularAñoBisiesto
{
    class AnioBisiesto
    {
        static void Main(string[] args)
        {
            DateTime fecha1;

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
