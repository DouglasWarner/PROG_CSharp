using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class ComprobarEsPrimo
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Esta aplicación comprueba la función EsPrimo.");
            Console.Write("Dime un número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine(EsPrimo(numero) ? "El "+numero+" es primo" : "El " + numero + " no es primo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static bool EsPrimo(int numero)
        {
            int contador = 0;

            if (numero <= 1)
                return false;
            if (numero == 2 || numero == 3)
                return true;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    contador++;
                if (contador > 2)
                    return false;
            }

            return true;
        }
    }
}
