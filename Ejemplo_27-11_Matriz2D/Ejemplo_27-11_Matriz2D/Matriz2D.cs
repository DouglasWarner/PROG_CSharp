using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_27_11_Matriz2D
{
    class Matriz2D
    {
        private int[,] _matriz2d;
        private int nFil = 10;
        private int nCol = 10;

        public Matriz2D()
        {
            this._matriz2d = new int[nFil, nCol];
        }

        public Matriz2D(int fil, int col)
        {
            nFil = fil;
            nCol = col;
            this._matriz2d = new int[nFil, nCol];
        }

        public void Ver()
        {
            for (int i = 0; i < nFil; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("{0}", _matriz2d[i,j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }   
        }

        public void Ver(int[,] m)
        {
            for (int i = 0; i < nFil; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("{0}", m[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            } 
        }
        public void Ver(int mult)
        {
            for (int i = 0; i < nFil; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (_matriz2d[i, j] % mult == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}", _matriz2d[i, j].ToString().PadLeft(5));
                        Console.ResetColor();
                    }
                    else
                        Console.Write("{0}", _matriz2d[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }

        public void Inicializa()
        {
            Random rnd = new Random();
            int limite = 100;

            for (int i = 0; i < nFil; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    _matriz2d[i, j] = rnd.Next(limite);
                }
            }
        }

        public void Inicializa(int valor)
        {

        }

        public int[,] Copia()
        {
            int[,] copia = new int[nFil, nCol];

            for (int i = 0; i < nFil; i++)
                for (int j = 0; j < nCol; j++)
                    copia[i, j] = _matriz2d[i, j];

            return copia;
        }
    }
}
