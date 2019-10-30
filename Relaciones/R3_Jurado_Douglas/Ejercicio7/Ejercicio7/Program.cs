/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Lee por teclado, hasta introducir un *, y imprime en mayúsculas las letras.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class AMayusculas
    {
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
