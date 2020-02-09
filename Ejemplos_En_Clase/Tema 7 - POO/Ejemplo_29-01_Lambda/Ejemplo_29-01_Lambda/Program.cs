using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_29_01_Lambda
{
    class Program
    {
        delegate int DlgEntero(int i);
        delegate void DlgEntero1(string s);

        static void Main(string[] args)
        {
            /*int n = 5;
            DlgEntero _dlgEntero = Cuadrado;
            DlgEntero _dlgLambda = x => x * x;

            Console.WriteLine("  METODO: El cuadrado de {0} es {1}", n, Cuadrado(n));
            Console.WriteLine("DELEGADO: El cuadrado de {0} es {1}", n, _dlgEntero(n));
            Console.WriteLine("  LAMBDA: El cuadrado de {0} es {1}", n, _dlgLambda(n));

            //---------------------------------------------
            DlgEntero1 _delegado = texto =>
                {
                    string s = texto + " Caracola";
                    Console.WriteLine(s);
                };
            //---------------------------------------------

            _delegado("Hola");*/

            new UsoDelegado().MetodoMain();

            new UsoLINQ().MetodoMain();

            Console.ReadLine();
        }

        static int Cuadrado(int x)
        {
            return x * x;
        }
    }
}
