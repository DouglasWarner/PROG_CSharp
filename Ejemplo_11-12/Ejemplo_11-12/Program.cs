using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder tarda menos ticks que String porque, al modificar String lo que hace el compilador es destruirlo
            // crear uno nuevo porque es un dato constante, pero con StringBuilder si modifica el dato.

            const string USU = "pepito";
            const string PWD = "12345";

            if (args.Length != 2)
                return;

            if(args[0] == USU && args[1] == PWD)
                Console.WriteLine("OK PASA");
            else
                Console.WriteLine("FUERA NIÑO");

            Console.ReadLine();

            //MostrarInfoMain(args);
        }

        static void MostrarInfoMain(string[] parametros)
        {
            Console.WriteLine("Información sobre los argumentos del método main");
            Console.WriteLine("".PadLeft(60,'-'));
            Console.WriteLine(" Número de parámetros: {0}", parametros.Length);
            Console.WriteLine("\n Ahí van los parámetros... ");
            for (int i = 0; i < parametros.Length; i++)
            {
                Console.WriteLine(" [{0}] - {1} ", i, parametros[i]);
            }

            Console.Write("\nPulsa una tecla....");
            Console.ReadLine();
        }
    }
}
