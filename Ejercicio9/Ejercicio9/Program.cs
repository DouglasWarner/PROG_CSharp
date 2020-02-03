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

            Console.ReadLine();
        }
    }
}
