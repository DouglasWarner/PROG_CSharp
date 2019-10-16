using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Menu
{
	class MenuPrincipalConColores
	{
		static void Main(string[] args)
		{
			PintaMenu(10, 5, ConsoleColor.Gray, ConsoleColor.Blue);

			Console.ReadLine();
		}

		static void PintaMenu(int posArriba, int posIzquierda, ConsoleColor colorFondo, ConsoleColor colorFuente)
		{
			// 10,5

			string tecla = string.Empty;

			do
			{
				Console.Clear();
				Console.CursorTop = posArriba;
				Console.CursorLeft = posIzquierda;
				Console.BackgroundColor = colorFondo;
				Console.ForegroundColor = colorFuente;

				Console.WriteLine("╔════════════════════════════════╗"); // ╚ ╔ ═ ║ ╗ ╝

				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║		MENU PRINCIPAL	      ║");

				Console.CursorLeft = posIzquierda;
				Console.WriteLine("╚════════════════════════════════╝");

				Console.CursorLeft = posIzquierda;
				Console.WriteLine("╔════════════════════════════════╗");

				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║	1. Alta			      ║");
				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║	2. Baja			      ║");
				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║	3. Consulta		      ║");
				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║	4. Modificar		      ║");
				Console.CursorLeft = posIzquierda;
				Console.WriteLine("║	0. Salir	              ║");
				Console.CursorLeft = posIzquierda;
				Console.WriteLine("╚════════════════════════════════╝");

				Console.CursorLeft = posIzquierda;
				Console.Write(" Elije una opción: ".PadLeft(27)+ "".PadRight(7));
				Console.SetCursorPosition(Console.CursorLeft - 7, Console.CursorTop);

				tecla = Console.ReadLine();

				try
				{
					switch (int.Parse(tecla))
					{
						case 1:
							Console.Clear();
							Console.WriteLine("Opcion 1");
							Console.ReadLine();
							break;
						case 2:
							Console.Clear();
							Console.WriteLine("Opcion 2");
							Console.ReadLine();
							break;
						case 3:
							Console.Clear();
							Console.WriteLine("Opcion 3");
							Console.ReadLine();
							break;
						case 4:
							Console.Clear();
							Console.WriteLine("Opcion 4");
							Console.ReadLine();
							break;
						case 0:
							Console.WriteLine("Opcion 0, Saliendo...");
							Console.ReadLine();
							break;
						default:
							break;
					}
				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
			} while (tecla != "0");
		}			
	}
}
