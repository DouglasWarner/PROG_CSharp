using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
using Sebas.App_DLL_Menu;

namespace Ejemplo_ReferenciarDDL
{
    class Program
    {
        static void Main(string[] args)
        {
            Sebas.App_DLL_Menu.Menu h = new Menu("Este es mi titulo", new string[] { "este", "es mi", "contenido" }, "Este es mi mensaje");

            h.MostrarMenu();

            Console.ReadLine();
        }
    }
}
