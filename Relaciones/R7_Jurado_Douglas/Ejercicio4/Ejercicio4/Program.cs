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
            string[] opcionesMenu = { "1. Factorial Recursivo", "2. Factorial Iterativo", "3. Fibonacci Iterativo", "4. Fibonacci Recursivo", "5. Suma Numeros Iterativo", "6. Suma Numeros Recursivo", "7. Es Primo","", "0. Salir" };
            string opcionSeleccionado = string.Empty;
            MenuPrincipal m = new MenuPrincipal("\tEjercicio 4", opcionesMenu, "Elige un opción: ", Tipo.Doble);

            do
            {
                Console.Clear();
                m.MostrarMenu(5, 30);

                switch ((opcionSeleccionado = Console.ReadLine()))
                {
                    case "1":
                        Console.Clear();
                        CalcularFactorialRecursivo();
                        break;
                    case "2":
                        Console.Clear();
                        CalcularFactorialIterativo();
                        break;
                    case "3":
                        Console.Clear();
                        CalcularFibonacciIterativo();
                        break;
                    case "4":
                        Console.Clear();
                        CalcularFibonacciRecursivo();
                        break;
                    case "5":
                        Console.Clear();
                        CalcularSumaIterativo();
                        break;
                    case "6":
                        Console.Clear();
                        CalcularSumaRecursivo();
                        break;
                    case "7":
                        Console.Clear();
                        CalcularNumeroPrimo();
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

        #region Factorial
        static void CalcularFactorialRecursivo()
        {
            int numero = 0;

            Console.WriteLine("     Cálculo del factorial de un número de forma recursiva   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", FactorialRecursivo(numero));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        static void CalcularFactorialIterativo()
        {
            int numero = 0;

            Console.WriteLine("     Cálculo del factorial de un número de forma iterativa   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", FactorialIterativo(numero));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        private static long FactorialRecursivo(long n)
        {
            if (n < 1)
                return 1;
            return n-- * FactorialRecursivo(n);
        }

        private static long FactorialIterativo(long num)
        {
            long resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
        #endregion

        #region Fibonacci
        static void CalcularFibonacciRecursivo()
        {
            int meses = 0;

            Console.WriteLine("     Cálculo del fibonacci de forma recursiva   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime los meses: ");
            try
            {
                meses = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", FibonacciRecursivo(meses));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        static void CalcularFibonacciIterativo()
        {
            int meses = 0;

            Console.WriteLine("     Cálculo del fibonacci de forma Iterativa   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime los meses: ");
            try
            {
                meses = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", FibonacciIterativo(meses));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        private static int FibonacciRecursivo(int meses)
        {
            if (meses == 1 || meses == 0)
                return 1;

            return FibonacciRecursivo(meses - 1) + FibonacciRecursivo(meses - 2);
        }

        private static int FibonacciIterativo(int meses)
        {
            int resultado = 0;
            int conejosAdultos = 0;
            int conejosBebes = 1;

            for (int i = 0; i < meses; i++)
            {
                resultado = conejosBebes + conejosAdultos;
                conejosAdultos = conejosBebes;
                conejosBebes = resultado;
            }

            return resultado;
        }
        #endregion

        #region Numero Primo
        static void CalcularNumeroPrimo()
        {
            int numero = 0;

            Console.WriteLine("         Cálculo si un número es primo   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", EsPrimo(numero) ? "El número "+numero+" es primo" : "El número "+numero+" no es primo");
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }
        
        private static bool EsPrimo(int numero)
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
        #endregion

        #region Sumas
        static void CalcularSumaRecursivo()
        {
            int numero = 0;

            Console.WriteLine("     Cálculo la suma de los primero números de forma Recursiva   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", SumaRecursiva(numero));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        static void CalcularSumaIterativo()
        {
            int numero = 0;

            Console.WriteLine("     Cálculo la suma de los primero números de forma Iterativa   ");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("\n   Dime el número: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("\n Resultado: {0}", SumaIterativa(numero));
            Console.Write("\n Pulsa cualquier tecla...");
            Console.ReadLine();
        }

        private static int SumaRecursiva(int num)
        {
            if (num < 1)
                return 0;
            return num + SumaRecursiva(--num);
        }

        private static int SumaIterativa(int num)
        {
            int resultado = 0;

            for (int i = 0; i <= num; i++)
                resultado += i;

            return resultado;
        }
        #endregion

    }
}
