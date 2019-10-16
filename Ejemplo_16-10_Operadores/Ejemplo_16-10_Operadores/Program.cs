using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_16_10_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 10;
            byte b = 254;
            char letra = 'A';
            
            Console.WriteLine("El valor de x es {0} y con y++ es {1}. Asigna despues.", x, y++);
            y = 10;

            Console.WriteLine("El valor de x es {0} y con ++y es {1}. Asigna antes.", x, ++y);
            
            // checked          CHECKED hace que compruebe si desborda la variable, y saltaria excepcion no controlada.
            //
                Console.WriteLine("\nPor defecto la comprobacion del desbordamiento de variables es unchecked. Esto es lo que sucede al incrementar.\n\nEl valor de b es {0}", b);
                Console.WriteLine("El valor de b es {0}", ++b);
                Console.WriteLine("El valor de b es {0}", ++b);
            //}

            Console.WriteLine("\n\n El ASCII de la letra {0} es {1}", letra, (int)letra);
            Console.WriteLine("\n\n El entero de 122 es la letra {0}", (char)122);

            Console.ReadLine();
        }
    }
}
