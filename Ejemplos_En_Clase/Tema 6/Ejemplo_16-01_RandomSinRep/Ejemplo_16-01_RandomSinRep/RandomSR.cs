/*----------------------------------------------------------------------
 *        Nombre: RandomSinRep
 *         Autor: Tu prima
 *         Fecha: 2 AC
 *       Función: Gestiona la creación de nº aleatorios sin repetición.
 *  Dependencias: Usa las clases auxiliares, bla, bla, bla
 * ---------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Douglas.Ejemplo_16_01_RandomSinRep
{
    class ExceptionPersonalizada : Exception
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public class RandomSR
    {
        Random alea;
        // Colección de números que han salido
        List<int> nGenerados = new List<int>();
        /// <summary>
        /// 
        /// </summary>
        public RandomSR()
        {
            alea = new Random();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="semilla"></param>
        public RandomSR(int semilla)
        {
            alea = new Random(semilla);
        }

        /// <summary>
        /// Genera un numero aleatorio.
        /// </summary>
        /// <returns>Devuelve el numero aleatorio generado.</returns>
        public int Siguiente()
        {
            const int MAX = 10;
            bool estaRepe = false;
            int nAlea = 0;
            int contador = 0;

            do
            {
                nAlea = alea.Next(MAX);
                estaRepe = nGenerados.Contains(nAlea);

            } while (estaRepe);
            nGenerados.Add(nAlea);
            return nAlea;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Siguiente(int min, int max)
        {
            bool estaRepe = false;
            int nAlea = 0;
            int contador = 0;

            do
            {
                nAlea = alea.Next(min, max);
                estaRepe = nGenerados.Contains(nAlea);

            } while (estaRepe);
            nGenerados.Add(nAlea);
            return nAlea;
        }
    }
}
