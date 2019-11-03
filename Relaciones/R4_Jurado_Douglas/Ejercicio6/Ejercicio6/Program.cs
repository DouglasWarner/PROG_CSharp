using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class EcuacionSegundoGrado
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Esta aplicación cálcula una ecuación de segundo grado.");
            try
            {
                Console.Write("Dime la A: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Dime la B: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Dime la C: ");
                c = int.Parse(Console.ReadLine());

                Console.WriteLine(ResolverEcuacionSegundoGrado(a, b, c));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static string ResolverEcuacionSegundoGrado(int a, int b, int c)
        {
            double raiz = (Math.Pow(b, 2) - (4 * a * c));

            if (a == 0)
                return "\nEl denominador no puede ser 0.";

            if(raiz < 0)
                return "\nLa raíz es negativa. No tiene solución.";

            if (raiz == 0)
                return string.Format("\nLa ecuación tiene solo una solución. x -> {0}.", -b / 2 * a);
            else
                return string.Format("\nx1 -> {0} \nx2 -> {1}", (-b + Math.Sqrt(raiz)) / (2 * a), (-b - Math.Sqrt(raiz)) / (2 * a));
        }
    }
}
