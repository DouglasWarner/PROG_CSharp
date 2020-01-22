using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_15_01_ClasePOJO
{
    class Program : Persona
    {
        static void Main(string[] args)
        {
            Persona yo = new Persona(100, "Risitas", "Jesus", DateTime.Now, 32600);

            Console.WriteLine(yo);

            Program p = new Program();
            p.Persona();

            Console.ReadLine();
        }

        public void Persona()
        {
            Console.WriteLine("yoquese");
        }
    }
}
