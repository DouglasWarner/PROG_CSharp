using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class AcertarNumero
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool acertaste = false;
            string tmp = string.Empty;

            //              MEJORABLE   
            Console.WriteLine("Juego de acertar el número del otro");
            Console.WriteLine("Dime el número que tiene que acertar");
            Console.ForegroundColor = ConsoleColor.Black;
            tmp = Console.ReadLine();
            Console.ResetColor();
            if (!int.TryParse(tmp, out numero1))
            {
                Console.WriteLine("Porfavor introduce un número.");
                Console.ReadLine();
                return;
            }
            
            do
            {
                tmp = Console.ReadLine();
                if (!int.TryParse(tmp, out numero2))
                {
                    Console.WriteLine("Porfavor introduce un número.");
                    Console.ReadLine();
                }

                if (numero1 == numero2)
                {
                    acertaste = true;
                    Console.WriteLine("Enhorabuena");
                    Console.ReadLine();
                }

            } while (!acertaste);
        }
    }
}
