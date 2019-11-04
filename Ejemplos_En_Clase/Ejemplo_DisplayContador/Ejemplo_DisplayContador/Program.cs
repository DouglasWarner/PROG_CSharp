using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------
using System.Threading;

namespace Ejemplo_DisplayContador
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();

            do
            {
                ActivarContador();

                Console.WriteLine("Resetear el contador? [s] [n]");
                tecla = Console.ReadKey();
                Console.ReadLine();

            } while (tecla.KeyChar != 'n');


            Console.ReadLine();
        }

        private static void ActivarContador()
        {
            for (int i = 0; i <= 99; i++)
            {
                Contador(i, 5, 5, 10);
            }
        }

        static void Contador(int num, int fil, int col, int retardo)
        {
            Console.Clear();
            string decimales = num.ToString();

            if (num < 10)
            {
                #region Unidades
                switch (num)
                {
                    case 0:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 1:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 2:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 3:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 4:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 5:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 6:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 7:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine(" 000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 8:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 9:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                }
                Thread.Sleep(retardo);
                #endregion
            }
            else
            {
                #region Unidades
                switch (int.Parse(decimales[0].ToString()))
                {
                    case 0:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 1:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 2:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 3:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 4:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 5:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 6:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 7:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine(" 000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 8:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 9:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                }
                #endregion
                col += 5;
                #region Unidades
                switch (int.Parse(decimales[1].ToString()))
                {
                    case 0:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 1:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 2:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 3:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 4:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 5:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 6:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0   ");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 7:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine(" 000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                    case 8:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        break;
                    case 9:
                        Console.SetCursorPosition(col, fil);
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0  0");
                        Console.CursorLeft = col;
                        Console.WriteLine("0000");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        Console.CursorLeft = col;
                        Console.WriteLine("   0");
                        break;
                }
                
                #endregion
            }
            Thread.Sleep(retardo);
        }
    }
}
