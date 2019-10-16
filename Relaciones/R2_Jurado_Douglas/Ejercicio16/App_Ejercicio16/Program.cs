/*----------------------------------------------------------------------
 * PROGRAMA: App_Ejercicio16
 *	  AUTOR: Douglas Warner Jurado Peña
 *    FECHA: 10/10/2019						VERSION: 1.0
 * COMENTARIO: Resuelve el area lateral y el volumen de un cilindro recto.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ejercicio16
{
	class CalculoAreaVolumenCilindro
	{
		static void Main(string[] args)
		{

			double area = 0.0;
			double volumen = 0.0;
			double radio = 0.0;
			double altura = 0.0;

			string tmp = string.Empty;

			Console.WriteLine("Voy a cálcular el área lateral y el volumen de un cilindro recto");
			Console.WriteLine("".PadLeft(30,'='));
			Console.Write("Dime el radio del cilindro: ");
			tmp = Console.ReadLine();

			if (!double.TryParse(tmp, out radio))			// Compruebo si se a introducido un double valido.
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce un radio valido");
				Console.ReadLine();
				return;
			}

			Console.Write("Dime la altura del cilindro: ");
			tmp = Console.ReadLine();
			if (!double.TryParse(tmp, out altura))			// Compruebo si se a introducido un double valido.
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce una altura valida");
				Console.ReadLine();
				return;
			}

			area = 2 * Math.PI * radio * altura;
			volumen = Math.PI * (radio * radio) * altura;

			Console.WriteLine("El área del cilindro recto es: {0} y el volumen es: {1}", Math.Round(area,2), Math.Round(volumen,2));

			Console.ReadLine();
		}
	}
}
