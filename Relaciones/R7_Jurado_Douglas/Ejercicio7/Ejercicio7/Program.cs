/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio7
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 13/02/2020						VERSION: 1.0
 * COMENTARIO: Esta aplicación interpreta el interfaz ICarrera
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t Aplicando una interfaz ICarrera, usando poliformimo, llamo al metodo Correr de cada objeto.");
            ICarrera coche = new Coche("Seat", "Leon");
            ICarrera deportista = new Deportista("Juan",29);

            coche.Correr();

            deportista.Correr();

            Console.ReadLine();
        }
    }
}
