using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            CFechas fecha = new CFechas();

            fecha.ValidarFecha(30, 3, 2020);

            Console.ReadLine();
        }
    }
}
