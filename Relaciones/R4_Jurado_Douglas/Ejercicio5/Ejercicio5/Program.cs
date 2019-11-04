using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int CASILLAS = 64;
            ulong granos = 1;

            Console.WriteLine("Esta aplicación pone a prueba la historia de un podesoro sultán que"+
                                "\ndeseaba recompensar a un estudiante por su servicio.");
            Console.WriteLine("Muestra la cantidad correspondiente en las casillas multiplos de 8.\n");

            Console.WriteLine("Casillas        Granos");
            for (int i = 1; i <= CASILLAS; i++)
            {
                if (i % 8 == 0)
                    Console.WriteLine("{0} -> {1:N}", i.ToString().PadLeft(2), granos.ToString("0,0").PadLeft(25));
                granos *= 2;
            }
            Console.ReadLine();
        }
    }
}
