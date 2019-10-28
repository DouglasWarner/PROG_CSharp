using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int LIM_FIL = Console.WindowHeight;
            int LIM_COL = Console.WindowWidth;
            int numCaracterAMostrar = 1000;
            char caracter = '/';
            Random rnd = new Random();
            int velocidad = 250;
            ConsoleColor color;
            int posFActual = 0;
            int posCActual = 0;

            for (int i = 0; i < numCaracterAMostrar; i++)
            {
                posFActual = rnd.Next(LIM_FIL);
                posCActual = rnd.Next(LIM_COL);
                Console.CursorVisible = false;
                Console.SetCursorPosition(posCActual, posFActual);
                Console.Write(caracter);
                Thread.Sleep(velocidad);
            }

            Console.ReadLine();
        }
    }
}

#region Ejemplos Hechos
/*      MOSTRAR EN BINARIO O HEXADECIMAL.
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0} -> {1}", i, Convert.ToString(i, 16));
            }*/

/*      MOSTRAR PAR O IMPAR DE NUMEROS RANDOM
int opcion = 50;
Random rnd = new Random();
int azar = 0;
string frase = string.Empty;

for (int i = 0; i < opcion; i++)
{
    azar = rnd.Next(100);
    frase = (azar % 2 == 0) ? "PAR" : "IMPAR";
    Console.WriteLine("{0} -> {1}", azar.ToString("000"), frase.PadLeft(5, ' '));
}*/

/*      SIMULACIÓN DE RELOJ
int velocidad = 1000;

for (int h = 0; h < 24; h++)
{
    for (int m = 0; m < 60; m++)
    {
        for (int s = 0; s < 60; s++)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.Write("{0}:{1}:{2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
            Thread.Sleep(velocidad);
        }
    }
}*/

/*      HORA SINCRONIZADA CON EL RELOJ DEL SISTEMA
while (true)
{
    Console.CursorVisible = false;
    Console.SetCursorPosition(10, 10);
    Console.Write(DateTime.Now.ToLongTimeString());
}*/
#endregion