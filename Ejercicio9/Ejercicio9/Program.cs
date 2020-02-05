using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        // Falta asignar movimiento aleatorio del tesoro

        static void Main(string[] args)
        {
            GestionJuego gj = new GestionJuego();
            
            gj.Jugar();

            /*Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-1,2));
                Console.WriteLine(rnd.Next(-1, 2));
            }*/
            Console.ReadLine();
        }
    }
}
