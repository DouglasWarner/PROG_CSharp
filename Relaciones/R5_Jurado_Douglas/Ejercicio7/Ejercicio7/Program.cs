/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 20/11/2019						VERSION: 1.0
 * COMENTARIO: Dado una frase la encripta siguiendo el algoritmo de encriptación de cesar, tambien para desencriptar.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static string abecedario = "abcdefghijklmnñopqrstuvwxyz";

        static void Main(string[] args)
        {
            string frase = string.Empty;
            int desplazamiento = 3;
            Console.WriteLine("Esta apliación encripta y desencripta con el algoritmo de encriptación de cesar.");
            Console.Write("Escribe la frase a encriptar: ");
            frase = Console.ReadLine();

            Console.WriteLine(Encriptar(frase, desplazamiento));

            Console.Write("Escriba la frase para desencriptar: ");
            frase = Console.ReadLine();

            Console.WriteLine(Desencriptar(frase, desplazamiento));

            Console.ReadLine();
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
