using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejercicio1;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuPrincipal m = new MenuPrincipal("Titulo principal", new string[] { "Opcion 1", "Opcion 2", "Opcion 3", "Opcion 4" }, "Elije una opcion: ", Tipo.Doble);

            m.MostrarMenu();

            m.MostrarMensaje("hola joio");

            Console.Clear();
            m.MostrarMenu(10, 50);

            Console.ReadLine();
        }
    }
}
