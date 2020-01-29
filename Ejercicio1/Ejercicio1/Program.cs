using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sebas.App_DLL_Menu;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Menu principal";
            string[] opciones = {"Hola","caracolssssssssa", "ehhh","que ase"};
            string mensaje = "Elige una opción: ";
            /*Marco m = new Marco(5, 5, 10, 10);
            
            m.DibujarMarcoSimple();*/

            MenuPrincipal mp = new MenuPrincipal(titulo, opciones, mensaje, Marco.Tipo.Doble);

            mp.MostrarMenu(10, 10, ConsoleColor.Blue, ConsoleColor.Black);

            /*Menu m = new Menu(titulo, opciones, mensaje);

            m.MostrarMenu(titulo, opciones, mensaje, ConsoleColor.Blue);*/


            Console.ReadLine();
        }
    }
}
