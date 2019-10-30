using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Ejercicio1
{
    class RelojDigital
    {
        static void Main(string[] args)
        {
            const int H = 24;
            const int M = 60;
            const int S = 60;
            const int PAUSA = 1000;

            for (int i = 13; i < H; i++)
            {
                for (int j = 20; j < M; j++)
                {
                    for (int k = 0; k < S; k++)
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(10, 10);
                        Console.WriteLine("{0}:{1}:{2}", i.ToString("00"), j.ToString("00"), k.ToString("00"));
                        Thread.Sleep(PAUSA);
                    }
                }
            }

        }
    }
}
