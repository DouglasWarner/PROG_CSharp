using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejercicio1;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opcionesMenu = { "1. Factorial Recursivo", "2. Factorial Iterativo", "3. Fibonacci Iterativo", "4. Fibonacci Recursivo", "5. Suma Numeros Iterativo", "   6. Suma Numeros Recursivo", "7. Es Primo", "0. Salir" };
            string opcionSeleccionado = string.Empty;
            MenuPrincipal m = new MenuPrincipal("\tEjercicio 4", opcionesMenu, "Elige un opción:", Tipo.Doble);

            do
            {
                Console.Clear();
                m.MostrarMenu(5, 30);

                switch ((opcionSeleccionado = Console.ReadLine()))
                {
                    case "1":
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(FibonacciIterativo(6));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(FibonacciRecursivo(6));
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();

                        break;
                    case "6":
                        Console.Clear();

                        break;
                    case "7":
                        Console.Clear();

                        break;
                    case "0":
                        m.MostrarMensaje("Seguro que quieres salir? s / n");
                        if (Console.ReadLine().ToLower() == "s")
                            return;
                        break;
                    default:
                        break;
                }

            } while (true);
        }

        static long FactorialRecursivo(long n)
        {
            if (n < 1)
                return 1;
            return n-- * FactorialRecursivo(n);
        }

        static long FactorialIterativo(long num)
        {
            long resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        static int FibonacciRecursivo(int meses)
        {
            if (meses == 1 || meses == 0)
                return 1;

            return FibonacciRecursivo(meses - 1) + FibonacciRecursivo(meses - 2);
        }

        static int FibonacciIterativo(int meses)
        {
            int resultado = meses;

            resultado += (meses - 1) + (meses - 2);

            return resultado;
        }

        static bool EsPrimo(int numero)
        {
            int contador = 0;

            if (numero <= 1)
                return false;
            if (numero == 2 || numero == 3)
                return true;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    contador++;
                if (contador > 2)
                    return false;
            }

            return true;
        }

        static int SumaRecursiva(int num)
        {
            if (num < 1)
                return 0;
            return num + SumaRecursiva(--num);
        }

        static int SumaIterativa(int num)
        {
            int resultado = 0;

            for (int i = 0; i <= num; i++)
                resultado += i;

            return resultado;
        }
    }
}
