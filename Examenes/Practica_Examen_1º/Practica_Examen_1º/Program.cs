using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_1º
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiradas = 6;
            Random rnd = new Random();
            int num = 5;
            int exponente = 5;

            Console.WriteLine("                 Practica examen");
            Console.WriteLine("===================================================================");
            Console.WriteLine("Tiempo en caer un objeto -> {0:F} s", TiempoEnCaerUnObjeto(180));
            Console.WriteLine("===================================================================");

            Console.WriteLine("Tirada de 3 dados");
            for (int i = 1; i <= tiradas; i++)
            {
                Console.WriteLine("Tirada {0}: {1}", i, TirarTresDados(rnd).ToString().PadLeft(3));
            }

            Console.WriteLine("===================================================================");

            Console.WriteLine("Funciones recursiva potencia un número");        // Base entre 0 y 100. Exponente positivo entre 0 y 10.
            Console.WriteLine("La potencia de base \"{0}\" y exponente de \"{1}\" es:", num, exponente);
            for (int i = 0; i < 1; i++)
            {
                /*Console.Write("Dime la base: ");
                num = int.Parse(Console.ReadLine());
                Console.Write("\nDime el exponente: ");
                exponente = int.Parse(Console.ReadLine());*/

                if ((exponente < 0 || exponente > 10) || (num < 0 || num > 100))
                {
                    i--;
                    Console.WriteLine("La base o el exponente no puede ser negativo");
                }
                else
                {
                    Console.WriteLine("Recursiva: {0}", PotenciaRecursiva(num, exponente));
                    Console.WriteLine("Iterativa: {0}", PotenciaIterativa(num, exponente));
                }
            }

            Console.WriteLine("===================================================================");
            Console.WriteLine("Arbol de X");
            PintarArbol('x', 6);

           /* Console.WriteLine("===================================================================");
            Console.WriteLine("Lee desde teclado N caracteres y contabiliza las vocales");
            string texto = string.Empty;
            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            do
            {
                tecla = Console.ReadKey();
                if(tecla.Key == ConsoleKey.Enter)
                    Console.WriteLine();
                else
                    texto += tecla.KeyChar;
            } while (texto[texto.Length-1] != '*');

            Console.WriteLine();
            ContarVocales(texto);
*/
            Console.WriteLine("===================================================================");

            Console.WriteLine("Suma de los número entre un mínimo y un máximo");
            Console.WriteLine("Recursiva: {0}", SumaRecursiva(5, 15));
            Console.WriteLine("Iterativa: {0}", SumaIterativa(5, 15));

            Console.WriteLine("===================================================================");

            DateTime fechaNac = new DateTime();
            string fecha = "10-5-1992";
            Console.WriteLine("Horoscopo");
            if(DateTime.TryParse(fecha, out fechaNac))
                Console.WriteLine(Horoscopo(fechaNac.Day, fechaNac.Month));
            else
                Console.WriteLine("Fecha de nacimiento erronea.");

            Console.WriteLine("===================================================================");

            Console.WriteLine("Comprobaciones varias");
            Console.WriteLine(Convert.ToBoolean(1));    // True
            Console.WriteLine(Convert.ToBoolean(0));    // False

            char leer = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine(leer);

            Console.ReadLine();
        }

        static double TiempoEnCaerUnObjeto(int altura)
        {
            double g = 9.81;

            if (altura < 0)
                return -1;

            return Math.Sqrt((2 * altura) / g);
        }

        static int TirarTresDados(Random rnd)
        {
            int numeroMaxDado = 7;
            int numeroMinDado = 1;
            int resultado = 0;
            int dados = 3;

            for (int i = 0; i < dados; i++)
            {
                resultado += rnd.Next(numeroMinDado, numeroMaxDado);
            }

            return resultado;
        }

        static int PotenciaRecursiva(int num, int exponente)
        {
            if (exponente == 0)
                return 1;

            return num * PotenciaRecursiva(num, --exponente);
        }

        static int PotenciaIterativa(int num, int exponente)
        {
            int resultado = 1;

            if (exponente == 0)
                return 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado *= num;
            }

            return resultado;
        }

        static void PintarArbol(char caracter, int altura)
        {
            int posDerecha = Console.CursorLeft + 10;
            int posIzquierda = Console.CursorLeft + 10;
            ConsoleColor rojo = ConsoleColor.Red;

            for (int i = 0; i < altura; i++)
            {
                Console.ForegroundColor = rojo;
                if (i == altura - 1)
                {
                    Console.CursorLeft = posIzquierda--;
                    Console.Write("".PadLeft(posDerecha - posIzquierda, caracter));
                }
                else
                {

                    Console.CursorLeft = posDerecha++;
                    Console.Write(caracter);
                    Console.CursorLeft = posIzquierda--;
                    Console.Write(caracter);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine("Pulsa una tecla...");
        }

        static void ContarVocales(string texto)
        {
            int a = texto.Count<Char>(x => x == 'a' || x == 'A');
            int e = texto.Count<Char>(x => x == 'e' || x == 'E');
            int i = texto.Count<Char>(x => x == 'i' || x == 'I');
            int o = texto.Count<Char>(x => x == 'o' || x == 'O');
            int u = texto.Count<Char>(x => x == 'u' || x == 'U');

            Console.WriteLine("a[{0}] -> {1}", a, "".PadLeft(a, '#'));
            Console.WriteLine("e[{0}] -> {1}", e, "".PadLeft(e, '#'));
            Console.WriteLine("i[{0}] -> {1}", i, "".PadLeft(i, '#'));
            Console.WriteLine("o[{0}] -> {1}", o, "".PadLeft(o, '#'));
            Console.WriteLine("u[{0}] -> {1}", u, "".PadLeft(u, '#'));

            Console.WriteLine("El total de caracteres es: {0}", texto.Length-1);
        }

        static int SumaRecursiva(int numMin, int numMax)
        {
            if (numMin == numMax)
                return numMax;

            return numMin + SumaRecursiva(++numMin, numMax);
        }

        static int SumaIterativa(int numMin, int numMax)
        {
            int result = 0;
            for (int i = numMin; i <= numMax; i++)
            {
                result += i;
            }
            return result;
        }

        static string Horoscopo(int dia, int mes)
        {
            #region Switch Horoscopo
            switch (mes)
            {
                case 1:
                    if (dia > 19)
                        return "Eres Aquarius";
                    else
                        return "Eres Capricornio";
                case 2:
                    if (dia > 18)
                        return "Eres Pisces";
                    else
                        return "Eres Aquarius";
                case 3:
                    if (dia > 20)
                        return "Eres Aries";
                    else
                        return "Eres Pisces";
                case 4:
                    if (dia > 19)
                        return "Eres Taurus";
                    else
                        return "Eres Aries";
                case 5:
                    if (dia > 20)
                        return "Eres Gemini";
                    else
                        return "Eres Taurus";
                case 6:
                    if (dia > 22)
                        return "Eres Leo";
                    else
                        return "Eres Gemini";
                case 7:
                    if (dia > 20)
                        return "Eres Cancer";
                    else
                        return "Eres Leo";
                case 8:
                    if (dia > 22)
                        return "Eres Virgo";
                    else
                        return "Eres Cancer";
                case 9:
                    if (dia > 22)
                        return "Eres Libra";
                    else
                        return "Eres Virgo";
                case 10:
                    if (dia > 22)
                        return "Eres Scorpio";
                    else
                        return "Eres Libra";
                case 11:
                    if (dia > 21)
                        return "Eres Sagittarius";
                    else
                        return "Eres Scorpio";
                case 12:
                    if (dia > 21)
                        return "Eres Capricornio";
                    else
                        return "Eres Sagittarius";
                default:
                    break;
            }
            #endregion

            return "";
        }
    }
}
