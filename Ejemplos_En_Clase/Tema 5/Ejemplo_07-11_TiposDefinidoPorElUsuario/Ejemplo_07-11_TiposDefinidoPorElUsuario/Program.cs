using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_07_11_TiposDefinidoPorElUsuario
{
    class Program
    {
        enum Dedo
        {
            Menique,
            Anular,
            Medio,
            Indice,
            Pulgar
        };

        struct Mascota
        {

        };

        static void Main(string[] args)
        {
            Dedo dedoMalito = new Dedo();
            Random rnd = new Random();

            dedoMalito = Dedo.Pulgar;

            Console.WriteLine("Mi dedo malito es {0}", (int)dedoMalito);

            Console.WriteLine("     Lista de dedos");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((Dedo)i);
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i <= 10; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next((int)ConsoleColor.Yellow);
                Console.WriteLine("Hola Caracola");
            }
            Console.ResetColor();
            Console.WriteLine("----------------------------");

            for (ConsoleColor i = ConsoleColor.Black; i <= ConsoleColor.Yellow; i++)
            {
                Console.ForegroundColor = i;
                Console.Write("* ");
            }
            Console.ReadLine();
        }
    }
}
