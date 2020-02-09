using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_03_02_SobrecargaOperador
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda DiasDescanso = new Agenda();
            string [] listaAnotaciones = null;

            if(DiasDescanso + "lunes")
                Console.WriteLine("Has añadido un dia de descanso");
            else
                Console.WriteLine("Demasiados descansos, pishaa");

            bool ant = DiasDescanso + "Jueves";

            for (int i = 0; i < 100; i++)
            {
                ant = DiasDescanso + "Martes";
            }

            // Recorrer sin indizadores, poniendo una propiedad que devuelve la lista de anotaciones.
            for (int i = 0; i < DiasDescanso.NAnotaciones; i++)
            {
                Console.WriteLine("\t [{0}]: {1} ", i, DiasDescanso.Anotaciones[i]);
            }
            Console.WriteLine("\n\n");
            // Recorrer con indizadores, poniendo la propiedad this[] con el que podemos obtener 
            // la lista de anotaciones por medio solo de la clase.
            for (int i = 0; i < DiasDescanso.NAnotaciones; i++)
            {
                Console.WriteLine("\t [{0}]: {1} ", i, DiasDescanso[i]);
            }

            listaAnotaciones = DiasDescanso.Anotaciones;

            // var es un tipo de valor que C# admite y la diferencia con los demas es que no tiene tipo
            foreach (var tmp in listaAnotaciones)
            {
                Console.WriteLine(tmp);
            }

            //DiasDescanso.Mostrar();

            Console.ReadLine();
        }
    }
}
