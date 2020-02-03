using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_03_02_SobrecargaOperador
{
    class Agenda
    {
        private const int N_ANOTACIONES = 10;
        private string[] _anotaciones = new string[N_ANOTACIONES];
        private int _ultAnotacion = 0;

        public int NAnotaciones
        {
            get { return _ultAnotacion; }
        }

        public string[] Anotaciones
        {
            get 
            {
                string[] ano = new string[_ultAnotacion];

                for (int i = 0; i < ano.Length; i++)
                {
                    ano[i] = _anotaciones[i];
                }

                return ano; 
            }
        }

        public string this[int indice]
        {
            get 
            {
                if (indice <= _ultAnotacion && indice > -1)
                    return _anotaciones[indice];
                else
                    return "Indice no valido, cohonee";
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < NAnotaciones; i++)
            {
                Console.WriteLine("\t [{0}]: {1} ", i, _anotaciones[i]);
            }

            Console.Write("\n\nNo hay mas anotaciones...");
            Console.ReadLine();
        }

        public static bool operator +(Agenda a, string anotacion)
        {
            if (a.NAnotaciones >= N_ANOTACIONES)
                return false;

            a._anotaciones[a._ultAnotacion++] = anotacion;

            return true;
        }
    }
}
