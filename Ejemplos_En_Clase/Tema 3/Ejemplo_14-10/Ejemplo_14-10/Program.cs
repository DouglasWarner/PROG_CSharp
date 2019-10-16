using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_14_10
{
	class Program
	{
		static void Main(string[] args)
		{
			int pvp = 25;
			int numero = 6552568;
			Console.WriteLine("El pvp es: {0:C}", pvp);
			Console.WriteLine("El formato Decimal es {0:D5}", pvp); // Solo es valido si el dato a imprimir por pantalla es de tipo entero.
			Console.WriteLine("El formato Cientifico es {0:E}", pvp);
			Console.WriteLine("El formato Punto Fijo es {0:F4}", pvp); // Decimales a la derecha a partir de la coma.
			Console.WriteLine("El formato General es {0:G}", pvp);
			Console.WriteLine("El formato Numerico es {0:N}", pvp);
			Console.WriteLine("El formato Hexadecimal es {0:X}", pvp);

			Console.WriteLine("El numero con longitud determinada {0,14:G}", pvp);
			Console.WriteLine("El numero con longitud determinada {0,14:X}", numero);

			Console.WriteLine("El numero con longitud determinada {0}", pvp.ToString().PadLeft(14));
			Console.WriteLine("El numero con longitud determinada {0}", numero.ToString().PadLeft(14));

			Console.ReadLine();
		}
	}
}
