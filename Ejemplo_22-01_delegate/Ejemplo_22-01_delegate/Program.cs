using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_22_01_delegate
{
    class Program
    {
        public delegate int MiDelegado(string msg);
        delegate void DlgOrdenar(int[] datos);

        static void Main(string[] args)
        {
            MiDelegado _delegado1 = MetodoParaDelegado1;
            _delegado1 += MetodoParaDelegado2;

            Console.WriteLine(_delegado1("hola"));

            Console.WriteLine(_delegado1.Method.Name);

            Console.WriteLine("\n\nCantidad de metodos subscritos al delegado: {0}\n\n", _delegado1.GetInvocationList());

            MetodoParaDelegado1("hola");
            MetodoParaDelegado2("adios");

            //------------------------------------------------
            //------------------------------------------------

            // Siguiente ejemplo

            int[] datos = { 9, 3, 6, 12, 0, 8, 2 };
            DlgOrdenar _mostrar = Ascendente;
            Mostrar(datos, _mostrar);

            Console.ReadLine();

            // Ejemplo Evento

            Evento eve = new Evento();

            eve.MiEvento += eve_MiEvento;

            eve.MetodoEvento();

            Console.ReadLine();
        }

        static void eve_MiEvento(string mensage)
        {
            Console.WriteLine((2*2).ToString() + " " + mensage);
        }

        static int MetodoParaDelegado1(string msg)
        {
            Console.Write("Soy MetodoParaDelegado1()... {0}", msg);
            Console.ReadLine();

            return 2;
        }

        static int MetodoParaDelegado2(string msg)
        {
            Console.Write("Soy MetodoParaDelegado2()... {0}", msg);
            Console.ReadLine();

            return 1;
        }

        static void Mostrar(int[] array, DlgOrdenar operacion)
        {
            operacion(array);
        }

        static void Ascendente(int[] array)
        {
            Console.WriteLine("\n\tMuestra los datos ascendentemente");
            Array.Sort(array);
            foreach (int item in array)
            {
                Console.Write("\n\t {0}",item);
            }
        }
        static void Descendente(int[] array)
        {
            Console.WriteLine("\n\tMuestra los datos ascendentemente");
            Array.Sort(array);
            Array.Reverse(array);
            foreach (int item in array)
            {
                Console.Write("\n\t {0}", item);
            }
        }
    }
}
