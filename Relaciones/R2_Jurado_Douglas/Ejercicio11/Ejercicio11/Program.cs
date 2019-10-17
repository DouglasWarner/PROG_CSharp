using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class HolaMundo
    {
        static void Main(string[] args)
        {
            string nombre = string.Empty;

            if (DateTime.Now.Hour > 13 && DateTime.Now.Hour < 21)
                Console.WriteLine("Buenas Tardes, ¿como te llamas?");
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 14)
                Console.WriteLine("Buenos Días, ¿como te llamas?");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}, ¡bienvenido al mundo de C#!", nombre);
            Console.ReadLine();
        }
    }
}
