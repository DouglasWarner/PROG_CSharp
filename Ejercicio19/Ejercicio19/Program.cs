using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroPersonas rgPer = new RegistroPersonas();
            string opcion = string.Empty;

            do
            {

                MostrarMenu();

            } while (opcion != "0");


            Console.ReadLine();

        }

        static void NavegarMenu(string opcion, RegistroPersonas registro)
        {
            int posTop = 5;
            string nombre = string.Empty;
            string apellido = string.Empty;
            string telefono = string.Empty;

            switch (opcion)
            {
                case "1":
                    Console.CursorTop = posTop;
                    registro.MostrarListado();
                    break;
                case "2":
                    Console.CursorTop = posTop;
                    Console.Write("Dime el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Dime los apellidos: ");
                    apellido = Console.ReadLine();
                    Console.Write("Dime el telefono: ");
                    telefono = Console.ReadLine();

                    registro.AnadirPersona(new Personas(nombre, apellido, telefono));

                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    return;
            }
        }

        static void MostrarMenu()
        {
            int posIzq = 30;
            Console.CursorTop = 5;
            Console.CursorLeft = posIzq;
            Console.WriteLine("\t\tREGISTROS DE PERSONAS");
            Console.CursorLeft = posIzq;
            Console.WriteLine("".PadLeft(posIzq+10,'-'));
            Console.CursorTop++;
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 1.   Listar Registro");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 2.    Añadir Persona");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 3.    Borrar Persona");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 4.    Buscar Persona");
            Console.CursorLeft = posIzq;
            Console.WriteLine(" 5. Modificar Persona");
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
