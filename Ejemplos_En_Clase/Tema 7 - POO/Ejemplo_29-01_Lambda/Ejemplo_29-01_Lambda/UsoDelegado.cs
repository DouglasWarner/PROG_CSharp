using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_29_01_Lambda
{
    class UsoDelegado
    {
        // Declaracion de un delegado
        delegate int dlgCuadrado(int x);

        public void MetodoMain()
        {
            int numero = 10;

            // C# 1.0: Uso de delegados
            Console.WriteLine("\n\t *** C# 1.0: Uso delegados ***");

            // Creo una instancia (objeto) del delegado que apunta a Cuadrado()
            dlgCuadrado _miDlgCuadrado = new dlgCuadrado(Cuadrado);

            // Llamo al objeto delegado y le paso un parámetro. CUMPLO LA FIRMA
            Console.WriteLine("\nMI DELEGADO {0} --> {1}", _miDlgCuadrado.GetType().Name, _miDlgCuadrado(numero));


            // C# 2.0: Uso de delegados con código de inicialización (métodos anónimos)
            Console.WriteLine("\n\t *** C# 2.0: Uso delegados con código de inicialización ***");

            dlgCuadrado _miDlgCuadradoAnonimo = delegate(int x)
            {
                return x * x;
            };

            Console.WriteLine("\nMI DELEGADO ANÓNIMO {0} --> {1}", _miDlgCuadradoAnonimo.GetType().Name, _miDlgCuadradoAnonimo(numero));

            // C# 3.0: Uso de delegados genérico integrado con expresión lambda
            Console.WriteLine("\n\t *** C# 3.0: Uso delegados con exp. Lambda ***");
            
            // Creo un delegado al que le asigno una exp lambda
            Func<int, int> _midlgCuadrado2 = x => x * x;

            Console.WriteLine("\nDELEGADO FUNC CON EXP. LAMBDA {0} --> {1}", _midlgCuadrado2.GetType().Name, _midlgCuadrado2(numero));

            Console.ReadLine();
        }

        private int Cuadrado(int x)
        {
            return x * x;
        }
    }
}
