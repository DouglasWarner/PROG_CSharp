using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_23_01_Eventos
{
    class Program
    {
        /* Cambiar el color
         * Mostrar en posiciones aleatorias
         * Mostrar en grande
         * etc
         */

        static void Main(string[] args)
        {
            Console.Title = string.Empty;
            Contador cont = new Contador();
            cont.Iniciar = !cont.Iniciar;
            cont.ConColores = !cont.ConColores;
            cont.ConPosicionAlea = !cont.ConPosicionAlea;

            cont.evtCambioContador += cont_evtCambioContador;

            cont.Contar();

            Console.ReadLine();
        }

        static void cont_evtCambioContador(int i)
        {
            Console.Title += "-";
            Console.Write(i);
        }
    }
}
