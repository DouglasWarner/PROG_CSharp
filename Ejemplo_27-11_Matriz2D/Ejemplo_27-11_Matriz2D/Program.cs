using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_27_11_Matriz2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz2D m2D = new Matriz2D();

            m2D.Inicializa();

            m2D.Ver();

            Console.WriteLine("\n\n");

            m2D.Ver(5);

            Console.WriteLine("\n\n");
            int[,] copia = m2D.Copia();
            copia[0, 0] = 0;
            m2D.Ver(copia);
            Console.WriteLine();
            m2D.Ver(5);
            
            Console.ReadLine();
        }
    }
}
