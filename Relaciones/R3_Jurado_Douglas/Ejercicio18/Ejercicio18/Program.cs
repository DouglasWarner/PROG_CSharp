/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio18
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 28/10/2019						VERSION: 1.0
 * COMENTARIO: Cálcula el área lateral y el volumen de un cilindro recto.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class CálculoAreaVolumenCilindro
    {
        static void Main(string[] args)
        {
            double radio = 0;
            double altura = 0;
            string tmp = string.Empty;

            Console.WriteLine("Esta aplicación cálcula el área lateral y el volumen de un cilindro recto.");

            Console.Write("Dime el radio: ");
            tmp = Console.ReadLine();
            if(!double.TryParse(tmp, out radio))
            {
                Console.WriteLine("Porfavor introduce un radio válido.");
                Console.ReadLine();
                return;
            }

            Console.Write("\nDime la altura: ");
            tmp = Console.ReadLine();
            if (!double.TryParse(tmp, out altura))
            {
                Console.WriteLine("Porfavor introduce un volumen válido.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("El área lateral del cilindro es: {0:F}", 2*Math.PI*radio*altura);
            Console.WriteLine("El volumen del cilindro es: {0:F}", Math.PI*(radio*radio)*altura);

            Console.Read();
        }
    }
}
