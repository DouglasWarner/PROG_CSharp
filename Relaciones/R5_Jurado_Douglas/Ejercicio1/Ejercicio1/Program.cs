using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class InformacionVariables
    {
        static void Main(string[] args)
        {
            object[] variables = { 'a', "a", 1, 2.3, true, 5.5F, -2, "abc".ToCharArray(), ConsoleColor.Red, DateTime.Now };

            MostrarInformacionDeTipos(variables);

            Console.ReadLine();
        }

        static void MostrarInformacionDeTipos(object[] tiposVariables)
        {
            foreach (object tmp in tiposVariables)
            {
                Console.WriteLine("Tipo -> {0}", tmp.GetType());
                Console.WriteLine("Tamaño que ocupa -> {0}");
                Console.WriteLine("Valor máximo -> {0}");
                Console.WriteLine("Valor mínimo -> {0}");
                Console.WriteLine("---------------------------------------------------");

            }
        }
    }
}
