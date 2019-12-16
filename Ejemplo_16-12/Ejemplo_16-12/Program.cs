using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_16_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja b1 = new Baraja();
            Naipe extraido = null;

            b1.VerBaraja();

            Console.WriteLine("".PadRight(40,'-'));

            extraido = b1.Extraer();
            b1.VerBaraja();
            Console.WriteLine(extraido.Info());

            
            Console.WriteLine(" DATOS DE LA CARTA ");
            Console.WriteLine("-----------------------------------------");
            foreach (string tmp in extraido.Formatear())
            {
                Console.WriteLine(tmp);
            }

            Console.ReadLine();
        }
    }
}
