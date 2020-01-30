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
            Persona yo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            Persona miniyo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            Persona secundyo = new Persona("Risitas", "Jesus", DateTime.Now, 32600);
            
            _bomberos.Anadir(yo);
            _bomberos.Anadir(miniyo);
            _bomberos.Anadir(secundyo);

            Console.WriteLine("\n\tHay {0} bomberos.",_bomberos.Cuantos);

            Console.WriteLine("\n\t {0}", yo.ToString());
            Console.WriteLine("\n\t {0}", miniyo.ToString());
            Console.WriteLine("\n\t {0}", secundyo.ToString());
            Console.ReadLine();
        }
    }
}
