using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desactiva la tecla control del sistema.
            Console.TreatControlCAsInput = true;
            Console.BufferHeight = 30;

            GestionJuego gj = new GestionJuego();
            
            gj.Jugar();
        }
    }
}
