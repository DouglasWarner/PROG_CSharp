/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio17
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 18/01/2020						VERSION: 1.0
 * COMENTARIO: Programa que gestiona una PILA de registros con los campos: nombre, código, fecha.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Datos> registro = new Stack<Datos>();
            string nombre = string.Empty;
            string fecha = string.Empty;
            string opcion = string.Empty;

            do
            {
                Console.Clear();
                Menu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.CursorTop = 5;
                        foreach (Datos item in registro)
                        {
                            Console.CursorLeft = 10;
                            Console.WriteLine(item);
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.CursorTop = 5;
                        Console.CursorLeft = 10;
                        Console.Write(" Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write(" Fecha: ");
                        fecha = Console.ReadLine();
                        try
                        {
                            registro.Push(new Datos(nombre, DateTime.Parse(fecha)));
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.CursorTop = 5;
                            Console.CursorLeft = 10;
                            Console.WriteLine("Error: Algo ocurrio.");
                            break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.CursorTop = 5;
                        Console.CursorLeft = 10;
                        Console.WriteLine(registro.Peek());
                        Console.Write("\nEste es el registro a borrar. Seguro que quieres borrarlor S /N ");
                        if (Console.ReadLine().ToLower() == "s")
                            registro.Pop();
                        break;
                    case "4":
                        Console.Clear();
                        Console.CursorTop = 5;
                        Console.CursorLeft = 10;
                        Console.WriteLine(registro.Peek());
                        Console.Write("\nEste es el siguiente registro.");
                        break;
                    default:
                        break;
                }
            } while (opcion != "0");
            
        }

        static void Menu()
        {
            int posIzq = 30;
            Console.CursorTop = 5;
            Console.CursorLeft = posIzq;
            Console.WriteLine("\t\tREGISTROS DE DATOS PERSONALES");
            Console.CursorLeft = posIzq;
            Console.WriteLine("".PadLeft(posIzq + 10, '-'));
            Console.CursorTop++;
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 1.   Listar Registro");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 2.    Añadir datos");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 3.    Borrar datos");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 4.    Buscar datos");
            Console.CursorLeft = posIzq;
            Console.CursorTop++;
            Console.WriteLine(" 0.             Salir");
            Console.CursorLeft = posIzq;
            Console.CursorTop += 2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     Elige una opción: ");
            Console.ResetColor();
        }
    }
}
