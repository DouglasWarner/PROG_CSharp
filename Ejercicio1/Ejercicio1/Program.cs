using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Menu principal";
            string[] opciones = {"Hola","caracola","que ase"};
            string mensaje = "Elige una opción: ";
            /*Marco m = new Marco(5, 5, 10, 10);

            m.DibujarMarcoSimple();*/

            MenuPrincipal mp = new MenuPrincipal(titulo, opciones, mensaje);

            mp.MostrarMenu(10, 10);

            Console.ReadLine();
        }
    }
}
