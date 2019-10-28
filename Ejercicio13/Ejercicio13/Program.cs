using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class MostrarExpresionesEspeciales
    {
        static void Main(string[] args)
        {
            int i = 5;

            Console.WriteLine("Las comillas dobles ( \" ) son especiales dentro del método Write");
            Console.WriteLine("Esto es una barra invertida \\");
            Console.WriteLine("El carácter \"\\t\" es tabulación horizontal");
            Console.WriteLine("El carácter \"\\n\" es salto de línea");
            Console.WriteLine("Los caracteres {} son especiales");
            Console.WriteLine("El primer valor se sustituye por {0} y vale: "+i);

            Console.ReadLine();
        }
    }
}
