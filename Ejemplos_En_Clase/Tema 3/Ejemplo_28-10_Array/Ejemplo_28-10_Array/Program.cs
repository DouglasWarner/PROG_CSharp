using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_28_10_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int alea = 0;              // Variable llamada x.
            int[] lista;
            lista = new int[10];     // Variable array de enteros, aún no se cuantos hay. Los array son tipo de datos por referencia.
            int[] listaPares = { 1, 2, 3, 4, 5 };
            int[] nuevaLista = new int[] { };

            Console.WriteLine(lista.Length);
            Console.WriteLine(listaPares.Length);
            Console.WriteLine(nuevaLista.Length);

            Console.WriteLine("Recorriendo la lista con for ");
            for (int i = 0; i < listaPares.Length; i++)
            {
                Console.Write(listaPares[i]+ " ");
            }

            Console.WriteLine();
            Console.WriteLine("Recorriendo la lista con foreach");
            foreach (int variable in listaPares)
            {
                Console.Write(variable+ " ");
            }

            //================================================================
            Console.WriteLine("\n\nContenido de lista vacía\n" + "".PadLeft(30, '='));

            foreach (int tmp in lista)
            {
                Console.Write(tmp + "".PadLeft(3));
            }

            Console.WriteLine("\n\nCreando una array con números aleatorios\n"+"".PadLeft(30,'='));
            Random rnd = new Random();

            for (int i = 0; i < lista.Length; i++)
            {
                alea = rnd.Next(1,20);
                lista[i] = (alea % 2 == 0) ? lista[i] = alea * 2 : lista[i] = alea;
            }

            foreach (int tmp in lista)
            {
                if (tmp % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(tmp + "  ");
                    Console.ResetColor();
                }
                else
                    Console.Write(tmp + "  ");
            }
            Console.ReadLine();
        }
    }
}
