using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class AMayusculas
    {
        /* Hacer un ordinograma que lea letras por teclado hasta introducir un *, 
         * y las vaya imprimiendo en mayúsculas. Los caracteres no letras los escribe tal cual.
         * Si quieres crea la función ‘AMayuscula’ y úsala.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe por teclado. Voy a convertirlas en mayuscula. Para terminar pulsa [*].");

            char letra = 'a';
            string frase = string.Empty;

            do
            {
                letra = (char)Console.Read();
                frase += AMayuscula(letra);

            } while (letra != '*');

            Console.Write(frase);

            Console.ReadLine();

            Console.ReadLine();
        }

        static char AMayuscula(char caracter)
        {
            if (!Char.IsLetter(caracter))
                return caracter;
            else
                return caracter = Char.ToUpper(caracter);
        }
    }
}
