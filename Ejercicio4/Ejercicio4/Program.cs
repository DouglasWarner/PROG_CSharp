﻿/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio4
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 16/12/2019						VERSION: 1.0
 * COMENTARIO: Esta aplicación quita los espacios que haya a la izquierda y a la derecha de la cadena de texto que se le pase.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            Console.WriteLine(" Esta aplicación quita los espacios que haya a la izquierda y a la derecha de la cadena de texto que se le pase.");
            Console.WriteLine("".PadRight(50, '-'));
            Console.Write(" Escribe el texto: ");
            texto = Console.ReadLine();

            Console.Write("\n El texto ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(texto);
            Console.ResetColor();
            Console.Write(" sin espacios al principio ni al final: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(QuitarEspaciosDerecha(QuitarEspaciosIzquierda(texto)));
            Console.ResetColor();

            Console.ReadLine();
        }

        static string QuitarEspaciosDerecha(string texto)
        {
            string tmpTexto = string.Empty;
            int posicionUltimoCaracter = 0;

            for (int i = texto.Length - 1; i > 0; i--)
                if (texto[i] != ' ')
                {
                    posicionUltimoCaracter = i;
                    break;
                }

            for (int i = 0; i <= posicionUltimoCaracter; i++)
            {
                tmpTexto += texto[i];
            }

            return tmpTexto;
        }
        static string QuitarEspaciosIzquierda(string texto)
        {
            string tmpTexto = string.Empty;
            int posPrimerCaracter = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    posPrimerCaracter = i;
                    break;
                }
            }

            for (int i = posPrimerCaracter; i < texto.Length; i++)
            {
                tmpTexto += texto[i];
            }

            return tmpTexto;
        }
    }
}
