using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p = new Punto(10,10);

            Cuadrado c = new Cuadrado(p, 2);

            c.DibujarCuadrado();

            Console.ReadLine();
        }
    }
}
