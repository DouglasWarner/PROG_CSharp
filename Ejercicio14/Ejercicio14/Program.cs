using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class FormatoDeSalida
    {
        static void Main(string[] args)
        {
            /*
             * Console.WriteLine("El pvp es: {0:C}", pvp);
			Console.WriteLine("El formato Decimal es {0:D5}", pvp); // Solo es valido si el dato a imprimir por pantalla es de tipo entero.
			Console.WriteLine("El formato Cientifico es {0:E}", pvp);
			Console.WriteLine("El formato Punto Fijo es {0:F4}", pvp); // Decimales a la derecha a partir de la coma.
			Console.WriteLine("El formato General es {0:G}", pvp);
			Console.WriteLine("El formato Numerico es {0:N}", pvp);
			Console.WriteLine("El formato Hexadecimal es {0:X}", pvp);

             * */
            int salida = 25;

            Console.WriteLine("Voy a mostrar dado un valor Integer, distintos tipos de formatos de salida con el método Write.");
            Console.WriteLine("".PadLeft(60,'-'));

            Console.WriteLine("{0:D5}", salida);
            Console.WriteLine("{0:E}", salida);
            Console.WriteLine("{0:N}", salida);
            Console.WriteLine("{0}", salida);
            Console.WriteLine("{0}", salida);
            Console.WriteLine("{0:N}", salida);
            Console.WriteLine("{0}", salida);
            Console.ReadLine();
        }
    }
}
