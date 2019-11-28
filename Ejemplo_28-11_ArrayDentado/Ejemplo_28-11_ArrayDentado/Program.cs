using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_28_11_ArrayDentado
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrizDentada mD = new MatrizDentada();
            int[,] a = new int[10, 10];
            Console.WriteLine(a.Length);
            Console.WriteLine(a.GetLength(a.Rank));

            
            mD.Ver();
            
            Console.WriteLine("\nMostrar la matriz Inicializada aleatoriamente\n");
            mD.InicializaAlea();
            mD.Mostrar();

            Console.ReadLine();
        }
    }
}
