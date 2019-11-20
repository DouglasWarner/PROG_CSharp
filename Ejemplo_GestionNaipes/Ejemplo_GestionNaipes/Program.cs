using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_GestionNaipes
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionBaraja espanoles = new GestionBaraja();

            /*GestionBaraja.Naipe naipe = new GestionBaraja.Naipe(GestionBaraja.Palos.Oro, GestionBaraja.Valor.Cuatro);

            espanoles.Anadir(naipe);

            naipe = new GestionBaraja.Naipe(GestionBaraja.Palos.Espada, GestionBaraja.Valor.Sota);

            espanoles.Anadir(naipe);

            espanoles.VerBaraja(false);
            */

            Console.WriteLine();

            espanoles.LlenarBaraja(20);

            espanoles.VerBaraja(true);

            Console.ReadLine();
        }
    }
}
