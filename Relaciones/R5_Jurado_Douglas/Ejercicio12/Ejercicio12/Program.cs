/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio12
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/11/2019						VERSION: 1.0
 * COMENTARIO: Programa que simula una baraja de cartas españolas. Creandola, permite extraer una carta aleatoriamente 
 *             hasta que la baraja se quede sin cartas.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Cartas
    {
        static void Main(string[] args)
        {
            BarajaEspanola baraja = new BarajaEspanola();

            baraja.MostrarBaraja();
            Console.WriteLine("\n" + new string('=',100));
            baraja.SacarCartas();
            Console.ReadLine();
        }
    }
}
