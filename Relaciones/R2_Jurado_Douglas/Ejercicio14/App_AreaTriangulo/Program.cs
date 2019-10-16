using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AreaTriangulo
{
	class AreaTriangulo
	{
		static void Main(string[] args)
		{
			double b = 0;
			double altura = 0;

			Console.WriteLine("Cálcular Área de un triangulo");
			Console.Write("Dime la base del triangulo: ");
			b = double.Parse(Console.ReadLine());
			Console.Write("Dime la altura del triangulo: ");
			altura = double.Parse(Console.ReadLine());

			Console.WriteLine("El área del triangulo con base {0} y altura {1} es {2}", b, altura, CalcularAreaTriangulo(b,altura).ToString());
			Console.ReadLine();
		}

		static double CalcularAreaTriangulo(double b, double altura)
		{
			return (b*altura)/2;
		}
	}
}
