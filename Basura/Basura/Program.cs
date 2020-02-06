using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejercicio1;

namespace Basura
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal m = new MenuPrincipal("hhhh", new string[] { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaa" }, "holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            m.MostrarMenu(10,0,150);

            Console.ReadLine();
        }
    }
}
