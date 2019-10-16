/*----------------------------------------------------------------------
 * PROGRAMA: App_Ejercicio15
 *	  AUTOR: Douglas Warner Jurado Peña
 *    FECHA: 10/10/2019						VERSION: 1.0
 * COMENTARIO: Resuelve el área de una circunferencia.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ejercicio15
{
	class AreaCircunferencia
	{
		static void Main(string[] args)
		{
			double radio = 0.0;
			string tmp = string.Empty;

			Console.WriteLine("Voy a cálcular el area de una circunferencia");
			Console.Write("Dime el radio: ");
			tmp = Console.ReadLine();

			if (!double.TryParse(tmp, out radio))
			{
				Console.SetCursorPosition(10, 15);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Porfavor introduce un radio valido");
				Console.ReadLine();
				return;
			}
			Console.SetCursorPosition(10, 15);
			Console.WriteLine("El área es: {0}", Math.PI * (radio * radio));
			
			Console.ReadLine();
		}
	}
}
