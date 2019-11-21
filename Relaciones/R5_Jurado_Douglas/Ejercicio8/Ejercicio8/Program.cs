/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 20/11/2019						VERSION: 1.0
 * COMENTARIO: Menu con los métodos encriptar y desencriptar.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static string abecedario = "abcdefghijklmnñopqrstuvwxyz";

        static void Main(string[] args)
        {
            string opcion = string.Empty;
            string fraseEncriptar = string.Empty;
            string fraseDesencriptar = string.Empty;
            int desplazamiento = 0;
            int posHorizontal = 15;
            int posVertical = 10;

            do
            {
                Console.Clear();
                PintarMenu(posHorizontal, posVertical);
                opcion = Console.ReadLine().ToLower();
                switch (opcion)
                {
                    case "a":
                        Console.Clear();
                        Console.CursorTop = posVertical;
                        Console.CursorLeft = posHorizontal;
                        Console.WriteLine("Escribe la frase a encriptar y el desplazamiento");
                        Console.CursorLeft = posHorizontal;
                        Console.WriteLine("================================");
                        Console.CursorLeft = posHorizontal;
                        Console.Write("Frase: ");
                        fraseEncriptar = Console.ReadLine();
                        Console.CursorLeft = posHorizontal;
                        Console.Write("Desplazamiento: ");
                        try
                        {
                            desplazamiento = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posHorizontal;
                            Console.Write("Resultado: {0}", Encriptar(fraseEncriptar, desplazamiento));
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posHorizontal;
                            Console.Write(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "b":
                        Console.Clear();
                        Console.CursorTop = posVertical;
                        Console.CursorLeft = posHorizontal;
                        Console.WriteLine("Escribe la frase a desencriptar y el desplazamiento");
                        Console.CursorLeft = posHorizontal;
                        Console.WriteLine("================================");
                        Console.CursorLeft = posHorizontal;
                        Console.Write("Frase: ");
                        fraseEncriptar = Console.ReadLine();
                        Console.CursorLeft = posHorizontal;
                        Console.Write("Desplazamiento: ");
                        try
                        {
                            desplazamiento = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posHorizontal;
                            Console.Write("Resultado: {0}", Desencriptar(fraseEncriptar, desplazamiento));
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posHorizontal;
                            Console.Write(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "s":
                        Console.CursorLeft = posHorizontal + 30;
                        Console.CursorTop = posVertical + 10;
                        Console.Write("Seguro que quieres salir? s / n  ");
                        opcion = Console.ReadLine().ToLower();
                        break;
                    default:
                        break;
                }

            } while (opcion != "s");


            Console.ReadLine();
        }

        static void PintarMenu(int posHorizontal, int posVertical)
        {
            Console.CursorLeft = posHorizontal;
            Console.CursorTop = posVertical;
            Console.WriteLine("     Menu Principal");
            Console.CursorLeft = posHorizontal;
            Console.WriteLine("==============================");
            Console.CursorLeft = posHorizontal;
            Console.WriteLine(" a. Encriptar");
            Console.CursorLeft = posHorizontal;
            Console.WriteLine(" b. Desencriptar");
            Console.CursorLeft = posHorizontal;
            Console.WriteLine(" s. Salir");
            Console.CursorLeft = posHorizontal;
            Console.WriteLine();
            Console.CursorLeft = posHorizontal;
            Console.Write("     Selecciona una opcion: ");
        }

        static string Encriptar(string frase, int desplazamiento)
        {
            int cantCaracter = frase.Length;
            int posCaracter = 0;
            string resultado = string.Empty;

            for (int i = 0; i < cantCaracter; i++)
            {
                posCaracter = PosicionCaracter(frase[i]);

                if (posCaracter != -1)
                    resultado += abecedario[(posCaracter + desplazamiento) % abecedario.Length];
                else
                    resultado += frase[i];
            }

            return resultado.ToUpper();
        }

        static string Desencriptar(string frase, int desplazamiento)
        {
            int cantCaracter = frase.Length;
            int posCaracter = 0;
            int posicionResult = 0;
            string resultado = string.Empty;

            for (int i = 0; i < cantCaracter; i++)
            {
                posCaracter = PosicionCaracter(frase[i]);

                if (posCaracter != -1)
                {
                    posicionResult = posCaracter - desplazamiento;
                    if (posicionResult < 0)
                        posicionResult += abecedario.Length;
                    resultado += abecedario[posicionResult];
                }
                else
                    resultado += frase[i];
            }

            return resultado.ToUpper();
        }

        static int PosicionCaracter(char letra)
        {
            for (int i = 0; i < abecedario.Length; i++)
            {
                if (letra == abecedario[i])
                    return i;
            }
            return -1;
        }
    }
}
