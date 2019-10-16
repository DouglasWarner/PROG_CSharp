/*----------------------------------------------------------------------
 * PROGRAMA: App_Ejemplo10-10
 *	  AUTOR: ....
 *    FECHA: ....						VERSION: 1.0
 * COMENTARIO: Resuelve una ecuación de 2º grado dado sus coeficientes
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ejemplo10_10
{
	class EcuacionSegundoGrado
	{
		static void Main(string[] args)
		{
			double a = 0.0;
			double b = 0.0;
			double c = 0.0;
			double dentroRaiz = 0.0;
			double x1 = 0.0;
			double x2 = 0.0;

			string comprobarConversion = "";

			Console.Clear();
			Console.WriteLine("Calcular ecuación de segundo grado");
			Console.WriteLine("".PadLeft(30,'='));
			Console.WriteLine();
			Console.Write("		Introduce el coeficiente a: ");
			comprobarConversion = Console.ReadLine();

			if (!double.TryParse(comprobarConversion, out a))
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce un numero");
				Console.ReadLine();
				return;
			}

			Console.Write("		Introduce el coeficiente b: ");
			comprobarConversion = Console.ReadLine();

			if (!double.TryParse(comprobarConversion, out b))
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce un numero");
				Console.ReadLine();
				return;
			}

			Console.Write("		Introduce el coeficiente c: ");
			comprobarConversion = Console.ReadLine();

			if (!double.TryParse(comprobarConversion, out c))
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce un numero");
				Console.ReadLine();
				return;
			}

			if (a==0)
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Esta ecuación no tiene solución posible");
				Console.ReadLine();
				return;
			}

			dentroRaiz = (b * b) - (4 * a * c);
			if (dentroRaiz < 0)
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Esta ecuación no tiene solución posible");
				Console.ReadLine();
				return;
			}

			x1 = (-b + Math.Sqrt(dentroRaiz)) / (2*a);
			x2 = (-b - Math.Sqrt(dentroRaiz)) / (2*a);

			Console.WriteLine("Resultado x1: {0} \nResultado x2: {1}", x1, x2);
			Console.ReadLine();
		}
	}
}
