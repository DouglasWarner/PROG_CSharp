/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio22
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 09/11/2019						VERSION: 1.0
 * COMENTARIO: Menu principal donde las opciones llevan a probar varias funciones.
 *---------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class MenuFinal
    {
        static void Main(string[] args)
        {
            // Campos del menu
            int posArb = 10;
            int posIzq = 10;
            bool salir = false;
            string tecla = string.Empty;
            // Resto de Division
            int dividendo = 0;
            int divisor = 0;
            // Pinta N veces el caracter
            char caracter = ' ';
            int nVeces = 0;
            // Es primo o no
            int numeroPrimo = 0;
            // Valor absoluto
            int numeroAbsoluto = 0;
            // Factorial Recursiva
            long numeroFacRecursiva = 0;
            // Factorial Iterativa
            long numeroFacIterativo = 0;
            // Potencia Recursiva
            double numeroPoRecursiva = 0;
            double exponentePoRecursiva = 0;
            // Año Bisiesto
            int anio = 0;
            // Los conejos de fibonacci
            int meses = 0;

            do
            {
                Console.Clear();
                PintaMenu();

                tecla = Console.ReadLine();

                switch (tecla)
                {
                    case "1":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Mostrar lista caracteres (Ej_02)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime el caracter: ");
                        try
                        {
                            caracter = char.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime el entero: ");
                            nVeces = int.Parse(Console.ReadLine());
                        }
                        catch (ArgumentNullException eANE)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(eANE.Message);
                        }
                        catch (FormatException eFE)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(eFE.Message);
                        }
                        Console.CursorLeft = posIzq;
                        Console.WriteLine(PintaCaracteres(nVeces, caracter));
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Probar si un número es primo (Ej_04)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime un número: ");
                        try
                        {
                            numeroPrimo = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(EsPrimo(numeroPrimo) ? "El " + numeroPrimo + " es primo" : "El " + numeroPrimo + " no es primo");
                        }
                        catch (Exception e)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Valor Absoluto (Ej_10)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime el número: ");
                        try
                        {
                            numeroAbsoluto = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.WriteLine("Valor absoluto de {0} es {1}", numeroAbsoluto, ValorAbsoluto(numeroAbsoluto));
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Factorial recursivo (Ej_12)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime el número a cálcular: ");
                        try
                        {
                            numeroFacRecursiva = long.Parse(Console.ReadLine());
                            if (numeroFacRecursiva > 20)
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("Porfavor el número debe ser menor que 20.");
                            }
                            Console.CursorLeft = posIzq;
                            Console.WriteLine("El factorial de {0} vale: {1}", numeroFacRecursiva, FactorialR(numeroFacRecursiva));
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Factorio iterativo (Ej_13)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime el número a cálcular: ");
                        try
                        {
                            numeroFacIterativo = long.Parse(Console.ReadLine());
                            if (numeroFacIterativo > 20)
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("Porfavor el número debe ser menor que 20.");
                                Console.ReadLine();
                            }
                            Console.CursorLeft = posIzq;
                            Console.WriteLine("El factorial de {0} vale: {1}", numeroFacIterativo, FactorialI(numeroFacIterativo));
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Potencia recursiva (Ej_16)");
                        try
                        {
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime la base: ");
                            numeroPoRecursiva = double.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime el exponente: ");
                            exponentePoRecursiva = double.Parse(Console.ReadLine());

                            if (numeroPoRecursiva == 0)
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("ERROR: La base no puede ser 0.");
                            }
                            else
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("El resultado de la potencia es: {0}", potenciaRecursiva(numeroPoRecursiva, exponentePoRecursiva));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Obtener el resto de división (Ej_17)");
                        try
                        {
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime el dividendo: ");
                            divisor = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime el divisor: ");
                            dividendo = int.Parse(Console.ReadLine());
                            Console.CursorLeft = posIzq;
                            Console.WriteLine("El resto de la división de {0} y {1}: {2}", divisor, dividendo, RestoDivision(divisor, dividendo));
                        }
                        catch (DivideByZeroException dEx)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(dEx.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Averiguar año bisiesto (Ej_18)");
                        try
                        {
                            Console.CursorLeft = posIzq;
                            Console.Write("Dime el año: ");
                            anio = int.Parse(Console.ReadLine());
                            if (EsBisiesto(anio))
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("El año {0} es bisiesto", anio);
                            }
                            else
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("El año {0} no es bisiesto", anio);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.Clear();
                        Console.CursorTop = posArb;
                        Console.CursorLeft = posIzq;
                        Console.WriteLine("Algoritmo Los conejos de Fibonacci Recursivo (Ej_19)");
                        Console.CursorLeft = posIzq;
                        Console.Write("Dime los meses: ");
                        try
                        {
                            meses = int.Parse(Console.ReadLine());
                            if (meses <= 0)
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("Error: Porfavor introduce una cantidad correcta.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.CursorLeft = posIzq;
                                Console.WriteLine("En {0} meses han nacido {1} par de conejos.", meses, Fibonacci(meses - 1));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.CursorLeft = posIzq;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "0":
                        Console.CursorLeft = posIzq;
                        Console.Write("¿Seguro que quieres salir? S / N ");
                        tecla = Console.ReadLine();
                        if (tecla == "s" || tecla == "S")
                            salir = true;
                        break;
                    default:
                        break;
                }

            } while (!salir);
        }

        static void PintaMenu()
        {
            int posArriba = 5;
            int posIzquierda = 5;

            Console.CursorLeft = posIzquierda;
            Console.CursorTop = posArriba;

            Console.WriteLine("".PadLeft(30, '='));
            Console.CursorLeft = posIzquierda;
            Console.WriteLine("       MENU PRINCIPAL ");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine("".PadLeft(30, '='));
            Console.CursorLeft = posIzquierda;
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 1.  Mostrar lista caracteres (Ej_02)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 2.  Probar si un número es primo (Ej_04)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 3.  Valor Absoluto (Ej_10)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 4.  Factorial recursivo (Ej_12)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 5.  Factorio iterativo (Ej_13)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 6.  Potencia recursiva (Ej_16)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 7.  Obtener el resto de división (Ej_17)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 8.  Averiguar año bisiesto (Ej_18)");
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 9.  Algoritmo Los conejos de Fibonacci Recursivo (Ej_19)");
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.WriteLine(" 0.  Salir");
            Console.WriteLine();
            Console.CursorLeft = posIzquierda;
            Console.Write(" Porfavor, pulsa una opción: ");
        }

        static double RestoDivision(int divisor, int dividendo)
        {
            return divisor % dividendo;
        }

        static string PintaCaracteres(int veces, char carac)
        {
            return "".PadLeft(veces, carac);
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

        static int ValorAbsoluto(int num)
        {
            return (num < 0) ? -(num) : num;
        }

        static long FactorialR(long n)
        {
            if (n < 1)
                return 1;
            return n-- * FactorialR(n);
        }

        static long FactorialI(long num)
        {
            long resultado = 1;

            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        static double potenciaRecursiva(double numero, double exponente)
        {
            if (exponente == 0 || numero == 1)
                return 1;

            if (exponente < 0)
                return 1 / numero * potenciaRecursiva(numero, exponente + 1);

            return numero * potenciaRecursiva(numero, exponente - 1);
        }

        static bool EsBisiesto(int anio)
        {
            return ((anio % 4 == 0 && !(anio % 100 == 0)) || anio % 400 == 0) ? true : false;
        }

        static int Fibonacci(int meses)
        {
            if (meses == 1 || meses == 0)
                return 1;

            return Fibonacci(meses - 1) + Fibonacci(meses - 2);
        }

    }
}