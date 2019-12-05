using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_05_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "hola car \n acola";

            int i = frase.LastIndexOf('a');

            Console.WriteLine(i);
            Console.WriteLine("hola".PadLeft(5,'-'));

            Console.WriteLine();

            Console.WriteLine((int)'\n');
            // Eliminar tambien el retorno de carro.

            string[] palabras = frase.Split(new char[] { ' ', (char)10, (char)13 }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string tmp in palabras)
            {
                Console.WriteLine(tmp);
            }

            CultureInfo idioma = new CultureInfo("es-ES");
            Console.WriteLine(idioma.EnglishName);

            Console.ReadLine();
        }
    }
}
