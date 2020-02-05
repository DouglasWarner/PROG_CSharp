using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejemplo_15_01_ClasePOJO;

namespace Ejemplo_15_01_ClasePOJO
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaPersonas _bomberos = new ListaPersonas();

            //  EJEMPLO 02/02
            /*Persona yo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            Persona miniyo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            Persona secundyo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);

            _bomberos.Anadir(yo);
            _bomberos.Anadir(miniyo);
            _bomberos.Anadir(secundyo);

            Console.WriteLine("\n\tHay {0} bomberos.",_bomberos.Cuantos);

            Console.WriteLine("\n\t {0}", yo.ToString());
            Console.WriteLine("\n\t {0}", miniyo.ToString());
            Console.WriteLine("\n\t {0}", secundyo.ToString());
            */
            
            // EJEMPLO 05/02 IENUMERATOR, IENUMERABLE

            _bomberos.Anadir("Risitas", "Jesus", DateTime.Now, 32600);
            _bomberos.Anadir("Risitas", "Jesus", DateTime.Now, 32600);
            _bomberos.Anadir("Risitas", "Jesus", DateTime.Now, 32600);
            _bomberos.AnadirVarios(10);

            _bomberos.Listar();

            Console.WriteLine("\n\n");

            foreach (var item in _bomberos)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("\n\n");

            Persona b1 = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            b1.Codigo = 10;

            Persona b2 = new Persona("Risitas", "Jesus", DateTime.Now, 32600);

            b2.Codigo = 10;

            Console.WriteLine("b1 <=> b1  , {0}", b1.Equals(b2));

            Console.ReadLine();
        }
    }
}
