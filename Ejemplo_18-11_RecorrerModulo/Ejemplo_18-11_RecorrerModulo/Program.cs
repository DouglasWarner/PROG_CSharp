using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_18_11_RecorrerModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int buscado = 0;
            int[] array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] array2 = null;
            int[] pruebaBinaria = CrearArrayEnteros(100000);
            string[] nombre = {"Pepe","Juan","Carla","Lucia","Sebastian","Eliseo"};
            VerSubarray(array, 2, 5);
            Console.WriteLine();
            VerSubarrayChar('a', 'e');
            
            buscado = Buscar(array, 6);
            if(buscado != -1)
                Console.WriteLine("Encontrado en la posición {0}",buscado);
            else
                Console.WriteLine("No encontrado");

            /*string[] query = nombre.OrderBy(x => x).ToArray();
            foreach (string tmp in query)
            {
                Console.Write("{0}\t",tmp);
            }*/

            // METODO BUSQUEDA BINARIA
            array2 = new int[array.Length];
            Array.Copy(array, array2, array.Length);
            Array.Sort(array2);
            if(BusquedaBinaria(array2, 6) != -1)
                Console.WriteLine("ENCONTRADO en BUSQUEDA BINARIA");
            else
                Console.WriteLine("NO ENCONTRADO en BUSQUEDA BINARIA");
            Console.ReadLine();
        }

        static int[] CrearArrayEnteros(int nDatos)
        {
            int[] vector = new int[nDatos];
            for (int i = 0; i < nDatos; i++)
            {
                vector[i] = i;
            }

            return vector;
        }
        static int BusquedaBinaria(int[] a, int datoBuscar)
        {
            int posInferior = 0;
            int posSuperior = a.Length - 1;
            int tamano = a.Length;
            int indice = (posInferior + posSuperior) / 2;

            while (a[indice] != datoBuscar && posInferior <= posSuperior)
            {
                indice = (posInferior + posSuperior) / 2;
                if (datoBuscar > a[indice])
                    posInferior = indice + 1;
                else
                    posSuperior = indice - 1;
            }
            if (a[indice] == datoBuscar)
                return indice;
            return -1;
        }
        static int Buscar(int[] a, int dato)
        {
            if (a.Length == 0)
                return -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == dato)
                    return i;
            }

            return -1;
        }
        static void VerSubarray(int[] d, int posInicial, int posFinal)
        {
            int limite = 32;
            int indice = 0;
            int[] datos = d;
            int nDatos = posFinal - posInicial + 1;

            for (int i = 0; i < limite; i++)
            {
                indice = posInicial + (i % nDatos);
                Console.Write("{0},\t", datos[indice]);
                if (posFinal == indice)
                    Console.WriteLine();
            }

        }

        static void VerSubarrayChar(char ini, char fin)
        {
            int indice = 0;
            int posIni = (int)ini;
            int posFin = (int)fin;
            int nDatos = posFin - posIni + 1;

            for (int i = 0; i < nDatos; i++)
            {
                indice = posIni + (i % nDatos);
                Console.Write("{0},\t", (char)indice);
                if (posFin == indice)
                    Console.WriteLine();
            }

        }
    }
}
