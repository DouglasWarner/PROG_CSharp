/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio11
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/11/2019						VERSION: 1.0
 * COMENTARIO: Programa que simula la tirada de dados y muestra por pantalla las veces que ha salido cada número y su porcentaje.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class TirarDados
    {
        static int[] dados = new int[7];
        static int totalTiradas = 0;

        static void Main(string[] args)
        {
            string readline = string.Empty;
            int tirada = 0;
            Console.WriteLine("Esta aplicación simula la tirada de dados");
            Console.Title = "Ejercicio 11 - Tirada de dados \t" + "Pulsa R - para reiniciar resultados. S - para salir.";
            Console.Write("Dime la cantidad de tiradas: ");

            while (true)
            {
                try
                {
                    readline = Console.ReadLine();
                    if (readline == "s")
                    {
                        return;
                    }
                    else if (readline == "r")
                    {
                        Reiniciar();
                    }
                    else
                    {
                        tirada = int.Parse(readline);
                        totalTiradas += tirada;
                        Console.WriteLine("         DADOS       ");
                        Console.WriteLine("====================================");
                        TirarDados(tirada);
                        MostrarDadosTirados();

                        Console.WriteLine("\nLlevas {0} tiradas", totalTiradas);
                    }
                    Console.Write("\nVuelve a tirar diciendo la cantidad de tiradas o pulsa r para reiniciar o s para salir ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        } 

        static void Reiniciar()
        {
            dados = new int[7];
            totalTiradas = 0;
            Console.WriteLine("\n\nReiniciado dados y tiradas");
        }

        static void MostrarDadosTirados()
        {
            for (int i = 1; i < dados.Length; i++)
            {
                Console.WriteLine("\n{0} - {1};\t {2}%", i, dados[i], PorcentajeDado(i));
            }
        }

        static float PorcentajeDado(int caraDelDado)
        {
            return (dados[caraDelDado]*100) / totalTiradas;
        }

        static bool TirarDados(int tirar)
        {
            Random rnd = new Random();
            int maxDado = 7;
            int minDado = 1;

            for (int i = 0; i < tirar; i++)
            {
                dados[rnd.Next(minDado, maxDado)]++;
            }

            return true;
        }
    }
}
