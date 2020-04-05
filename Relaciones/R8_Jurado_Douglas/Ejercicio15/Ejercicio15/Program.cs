/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio15
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 23/03/2020						VERSION: 1.0
 * COMENTARIO: App que gestiona un almacen de articulos.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using System.IO;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionMenu menuArticulo = new GestionMenu();

            menuArticulo.NavegarPorMenu();
        }
    }
}
