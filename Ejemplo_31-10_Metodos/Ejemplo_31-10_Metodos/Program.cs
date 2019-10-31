using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_31_10_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValorAbsoluto(-9000));

            Console.ReadLine();
        }

        static int ValorAbsoluto(int num)
        {
            return (num < 0) ? -(num) : num;
        }
        static decimal ValorAbsoluto(decimal num)
        {
            return (num < 0) ? -(num) : num;
        }
        static double ValorAbsoluto(double num)
        {
            return (num < 0) ? -(num) : num;
        }
        static float ValorAbsoluto(float num)
        {
            return (num < 0) ? -(num) : num;
        }
        static long ValorAbsoluto(long num)
        {
            return (num < 0) ? -(num) : num;
        }
        static sbyte ValorAbsoluto(sbyte num)
        {
            return (num < 0) ? (sbyte)-(num) : (sbyte)num;
        }
        static short ValorAbsoluto(short num)
        {
            return (num < 0) ? (short)-(num) : (short)num;
        }
    }
}
