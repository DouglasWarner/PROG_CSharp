/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio8
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 13/02/2020						VERSION: 1.0
 * COMENTARIO: Esta aplicación gestiona un conjunto de vehiculos utilizando la herencia.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c = new Coche("Seat",4,ConsoleColor.Red, Vehiculo.TipoTraccion.Delantera, 180);

            c.Marchar();

            Moto m = new Moto("BMW", 2, ConsoleColor.Black, Vehiculo.TipoTraccion.Trasera, 120, Moto.TipoCombustible.normal);
            Bicicleta b = new Bicicleta("Del Campo", 2, ConsoleColor.Blue, Vehiculo.TipoTraccion.Trasera, 250.49F, DateTime.Now);
            Montaña bM = new Montaña("No fear", 2, ConsoleColor.Cyan, Vehiculo.TipoTraccion.Total, 359.99F, DateTime.Now, false, 16, Montaña.TipoAmortiguacion.suave);
            Paseo bP = new Paseo("De Paseo", 2, ConsoleColor.DarkMagenta, Vehiculo.TipoTraccion.Trasera, 150, DateTime.Now, 2, "Model EXCLUSIVO", "GUCCI");

            Console.WriteLine(m);
            Console.WriteLine(b);
            Console.WriteLine(bM);
            Console.WriteLine(bP);


            Console.ReadLine();

        }
    }
}
