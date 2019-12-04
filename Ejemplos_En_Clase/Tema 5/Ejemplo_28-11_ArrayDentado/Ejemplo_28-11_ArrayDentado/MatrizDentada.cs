using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_28_11_ArrayDentado
{
    class MatrizDentada
    {
        private int[][] _matrizDentada;

        int d0;
        int d1;
        int d2;

        public MatrizDentada()
        {
            _matrizDentada = new int[2][] 
            { 
                new int[3], 
                new int[5] 
            };
            d0 = _matrizDentada.Length;
            d1 = _matrizDentada[0].Length;
            d2 = _matrizDentada[1].Length;
        }

        public void Ver()
        {
            for (int i = 0; i < d0; i++)
            {
                if (i == 0)
                {
                    Console.Write("Matriz [0] -> ");
                    for (int j = 0; j < d1; j++)
                    {
                        Console.Write(_matrizDentada[i][j].ToString().PadLeft(3));
                    }
                }
                Console.WriteLine();
                if (i == 1)
                {
                    Console.Write("Matriz [1] -> ");
                    for (int j = 0; j < d2; j++)
                    {
                        Console.Write(_matrizDentada[i][j].ToString().PadLeft(3));
                    }
                }
            }

            Console.Write("\n\n No hay mas datos a mostrar, pulsa cualquier tecla... ");
            Console.ReadLine();
        }

        public void Mostrar()
        {
            Ver(_matrizDentada);
        }

        public void Ver(int[][] m)
        {
            int d0 = m.Length;

            for (int i = 0; i < d0; i++)
            {
                Console.Write("M[{0}] -> ", i);

                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write("{0,3}", m[i][j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            Console.Write("\n\n No hay mas datos a mostrar, pulsa cualquier tecla... ");
            Console.ReadLine();
        }

        public void InicializaAlea()
        {
            const int LIMITE = 100;
            Random rnd = new Random();

            for (int i = 0; i < d0; i++)
            {
                if(i==0)
                    for (int j = 0; j < d1; j++)
                        _matrizDentada[i][j] = rnd.Next(LIMITE + 1);
                if(i==1)
                    for (int j = 0; j < d2; j++)
                        _matrizDentada[i][j] = rnd.Next(LIMITE + 1);
            }
        }
    }
}
