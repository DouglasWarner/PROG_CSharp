using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_21_11_ArrayInsertar_Borrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int datoABuscar = 0;
            GestionArray a1 = new GestionArray(1000);
            GestionArray a2 = new GestionArray();

            Console.WriteLine("Soy el a1 con tamaño por 1000");
            a1.VerArray();
            a1.InsertarValores(25);
            a1.VerArray();
            a1.Borrar(0);
            a1.Borrar(0);
            a1.VerArray();

            
            try
            {
                Console.Write("Se busca un dato, dime su valor: ");
                datoABuscar = int.Parse(Console.ReadLine());
                Console.Write("Borrar?: " + a1.Buscar(datoABuscar)+ "   s / n ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("==========================================\n");
            Console.WriteLine("Método de ordenamiento de burbuja\n");
            GestionArray a3 = new GestionArray(40);
            a3.InsertarValores(40);
            a3.VerArray();
            Console.WriteLine("\n\n");
            Console.WriteLine(" Ordenado\n");
            a3.OrdBurbuja();
            a3.VerArray();

            Console.ReadLine();
        }
    }
}
