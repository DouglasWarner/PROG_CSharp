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
            Punto p1 = new Punto(25, 20);
            Cuadrado c = new Cuadrado(p, p1);

            c.DibujarAleatorio();

            Console.ReadLine();
        }
    }
}
