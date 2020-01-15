﻿/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio13
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 15/01/2020						VERSION: 1.0
 * COMENTARIO: Devuelve una lista de palabras comenzando por mayuscula la primera letra.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("     Esta aplicación devuelve una lista de palabra, de una frase, comenzando por mayuscula cada una.");
            Console.WriteLine("     Escribe a continuación la frase.");
            Console.WriteLine("".PadLeft(50,'-'));
            frase = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
