using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class ConvertirCaracterAMayuscula
    {
        static void Main(string[] args)
        {
            char caracter = ' ';
            int fil = 0;
            int col = 0;

            Console.WriteLine("Esta aplicación pasa un caracter del abecedario de minuscula a mayuscula.");
            Console.Write("Dime el caracter: ");

            fil = Console.CursorTop;
            col = Console.CursorLeft;

            try
            {
                caracter = char.Parse(Console.ReadLine());

                if ((int)caracter > 96 && (int)caracter < 123 || caracter == 'ñ')
                {
                    Console.SetCursorPosition(col, fil);
                    Console.Write("{0} -> {1}", caracter, AMayuscula(caracter));
                }
                else
                    Console.WriteLine("Porfavor pase como caracter una letra del abecedario");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
        }

        static char AMayuscula(char caracter)
        {
            return (char)((int)caracter - 32);
        }
    }
}
