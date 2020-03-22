/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio13
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 16/03/2020						VERSION: 1.0
 * COMENTARIO: Guarda información sobre la conexión de un usuario en un fichero.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------
using System.IO;
using System.Threading;

namespace Ejercicio13
{
    class Program
    {
        static bool salir = false;
        static DateTime tiempoInicio = DateTime.Now;
        static DateTime tiempoFin = new DateTime();

        static void Main(string[] args)
        {
            string fichero = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "datos.txt";
            Thread tiempo = new Thread(new ThreadStart(TiempoConexion));

            tiempo.Start();
            

            Console.WriteLine("\n\tC O N E C T A D O");

            Console.WriteLine("\n\tHaciendo lo que sea");

            while (true)
            {
                if(salir)
                {
                    using (FileStream fs = new FileStream(fichero, FileMode.Append, FileAccess.Write))
                    using(StreamWriter sw = new StreamWriter(fs))
                    {
                        TimeSpan intervalo = tiempoFin - tiempoInicio;

                        sw.WriteLine(string.Format("Nombre: {0}\tFecha: {1}\tHora: {2}\tTiempo de conexión: {3} sec", 
                            "NombreUsuario", 
                            tiempoFin.ToShortDateString(), 
                            tiempoFin.ToShortTimeString(), 
                            intervalo.Seconds));
                    }
                    return;
                }
            }
        }

        static void TiempoConexion()
        {
            while (!salir)
            {
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    Console.WriteLine("\n\tD E S C O N E C T A D O");
                        
                    salir = true;
                }

                tiempoFin = DateTime.Now;
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
