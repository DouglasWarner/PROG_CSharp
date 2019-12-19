using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_19_12
{
    public struct Ficha
    {
        // CUIIIIDAAAOOOOO CON PONERLO PUBLICO
        public int id;
        public string nombre;
        public double estatura;
        // Y muchos mas datos....

        public Ficha(int i, string nom, double est)
        {
            id = i;
            nombre = nom;
            estatura = est;
        }
    
    }

    class Program
    {
        static Dictionary<int, Ficha> dic = new Dictionary<int, Ficha>();

        static void Main(string[] args)
        {
            Ficha f1 = new Ficha(100, "pepito", 1.99);
            Ficha f2 = new Ficha(101, "juanito", 1.20);
            Ficha f3 = new Ficha(102, "joselito", 1.60);

            if (Anadir(f1) && Anadir(f2) && Anadir(f3))
            {
                Console.WriteLine("Añadidos");
            }
            else
                Console.WriteLine("Algo ocurrio con los datos");

            Console.ReadLine();
        }

        static bool Anadir(Ficha f)
        {
            int clave = f.id;
            if (dic.ContainsKey(clave))
                return false;

            dic.Add(clave, f);

            return true;
        }
    }
}
