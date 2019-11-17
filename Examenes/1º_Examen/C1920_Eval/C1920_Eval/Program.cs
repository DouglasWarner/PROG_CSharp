using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1920_Eval
{
    class Examen1Trimestre
    {
        static void Main(string[] args)
        {
            #region Variables Del Programa
            // Variables del Menu
            char tecla = ' ';
            bool salir = false;
            string respuetaSalir = string.Empty;
            int posIzquierda = 0;
            int posArriba = 0;
            
            //  Variables de Numeros a letras
            int numero = 0;

            // Variables de Media de numeros
            double numeroMedia = 0;
            double sumNumero = 0;
            int cantidadNumero = 0;
            int indiceNota = 1;

            // Variables de Contar vocales
            char caracter = ' ';
            string contabilizarVocal = string.Empty;

            // Variables de Mostrar codigo ASCII
            char caracterASCII = ' ';
            #endregion

            do
            {
                Console.Clear();
                PintarMenu();
                try
                {
                    tecla = char.Parse(Console.ReadLine());
                }
                #region Excepciones
                    catch (ArgumentNullException aex)
                    {
                        Console.WriteLine(aex.Message);
                        continue;
                    }
                    catch (FormatException fex)
                    {
                        Console.WriteLine(fex.Message);
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                #endregion

                switch (char.ToLower(tecla))
                {
                    case 'a':
                        Console.Clear();
                        Console.WriteLine(" Convierto Números a su valor en letras, para salir introduce cualquier número negativo. ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        do
                        {
                            try
                            {
                                Console.Write("\n Dime un número: ");
                                posIzquierda = Console.CursorLeft;
                                posArriba = Console.CursorTop;
                                numero = int.Parse(Console.ReadLine());
                                
                                if (numero < 0) // Expresion booleana para finalizar.
                                    break;
                                if (numero > 9)
                                    Console.WriteLine("Porfavor introduce un número entre 0 y 9");
                                else
                                {
                                    Console.CursorLeft = posIzquierda+2;
                                    Console.CursorTop = posArriba;
                                    Console.Write(" -> {0}", NumerosALetras(numero));
                                }
                            }
                            #region Excepciones
                                catch (ArgumentNullException aex)
                                {
                                    Console.WriteLine(aex.Message);
                                }
                                catch (FormatException fex)
                                {
                                    Console.WriteLine(fex.Message);
                                }
                                catch (OverflowException ofex)
                                {
                                    Console.WriteLine(ofex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            #endregion
                        } while (true);
                        break;
                    case 'b':
                        Console.Clear();
                        Console.WriteLine(" Realizo la media de una serie de números, para finalizar introduce un CERO. ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        do
                        {
                            Console.Write(" Nota {0}: ", indiceNota.ToString().PadLeft(3));     // Un indice para que se sepa la cantidad de notas                                                                                                          validas que se han introducido
                            try
                            {
                                numeroMedia = double.Parse(Console.ReadLine());

                                if (numeroMedia == 0)   // Expresion booleana para finalizar.
                                    break;
                                sumNumero += numeroMedia;
                                cantidadNumero++;
                                indiceNota++;   // Aumento el indice
                            }
                            #region Excepciones
                                catch (ArgumentNullException aex)
                                {
                                    Console.WriteLine(aex.Message);
                                }
                                catch (FormatException fex)
                                {
                                    Console.WriteLine(fex.Message);
                                }
                                catch (OverflowException ofex)
                                {
                                    Console.WriteLine(ofex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            #endregion

                        } while (true);

                        // Compruebo si se ha introducido algún número
                        if (cantidadNumero > 0)
                        {
                            Console.WriteLine("\nLa media de los {0} notas es {1:F2}", cantidadNumero, sumNumero / cantidadNumero);
                            Console.ReadLine();
                        }

                        // Reinicio las variables, por si se vuelve a seleccionar esta opcion del menu.
                        sumNumero = 0;
                        cantidadNumero = 0;
                        indiceNota = 1;

                        break;
                    case 'c':
                        Console.Clear();
                        Console.WriteLine(" Dado una serie de caracteres introducidos por teclado y cuenta el número total de cada vocal. ");
                        Console.WriteLine(" Introduce caracter a caracter, para finalizar introduce un *. ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(" Introduce los caracteres ");
                        do
                        {
                            try
                            {
                                Console.CursorLeft = 2;
                                caracter = char.Parse(Console.ReadLine());
                                if (caracter == '*')    // Expresion booleana para finalizar.
                                    break;
                                contabilizarVocal += char.ToLower(caracter);
                            }
                            #region Excepciones
                                catch (ArgumentNullException aex)
                                {
                                    Console.WriteLine(aex.Message);
                                    continue;
                                }
                                catch (FormatException fex)
                                {
                                    Console.WriteLine(fex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            #endregion
                            
                        } while (true);

                        Console.WriteLine();
                        // Llamo al método ContarVocales introduciendo el conjunto de vocales introducidos y cada vocal
                        Console.WriteLine(" Cantidad de vocales a -> {0}", ContarVocales(contabilizarVocal, 'a').ToString().PadLeft(2));
                        Console.WriteLine(" Cantidad de vocales e -> {0}", ContarVocales(contabilizarVocal, 'e').ToString().PadLeft(2));
                        Console.WriteLine(" Cantidad de vocales i -> {0}", ContarVocales(contabilizarVocal, 'i').ToString().PadLeft(2));
                        Console.WriteLine(" Cantidad de vocales o -> {0}", ContarVocales(contabilizarVocal, 'o').ToString().PadLeft(2));
                        Console.WriteLine(" Cantidad de vocales u -> {0}", ContarVocales(contabilizarVocal, 'u').ToString().PadLeft(2));

                        // Reinicio el string donde contabilizo las vocales, por si se vuelve a seleccionar opcion del menu.
                        contabilizarVocal = string.Empty;   

                        Console.ReadLine();
                        break;
                    case 'd':
                        Console.Clear();
                        Console.WriteLine(" Muestra el valor del ACSII de un caracter, para finalizar introduce un *. ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        do
                        {
                            try
                            {
                                Console.Write(" Caracter: ");
                                caracterASCII = char.Parse(Console.ReadLine());
                                if (((int)caracterASCII >= 33) && ((int)caracterASCII <= (int)'Ñ'))
                                {
                                    Console.CursorLeft += 15;
                                    Console.CursorTop--;
                                    Console.WriteLine(" -> {0}",(int)caracterASCII);
                                }
                            }
                            #region Excepciones
                                catch (ArgumentNullException aex)
                                {
                                    Console.WriteLine(aex.Message);
                                    continue;
                                }
                                catch (FormatException fex)
                                {
                                    Console.WriteLine(fex.Message);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            #endregion
                            if (caracterASCII == '*')   // Expresion booleana para finalizar.
                                break;
                            
                        } while (true);
                        break;
                    case 's':
                        Console.CursorTop++;
                        Console.CursorLeft += 5;
                        Console.Write(" ¿Estas seguro que quieres salir? s / n ");      // Pregunto antes de salir.
                        respuetaSalir = Console.ReadLine();
                        if (respuetaSalir == "s")
                            salir = true;
                        break;
                    default:
                        break;
                }

            } while (!salir);

            Console.ReadLine();
        }

        /// <summary>
        /// Pinta el Menu del programa
        /// </summary>
        static void PintarMenu()
        {
            Console.WriteLine("     MENU PRINCIPAL - 1º Eva. 19/20. Jurado D.");
            Console.WriteLine("".PadLeft(50,'='));
            Console.WriteLine("   a.- Números a letras.");
            Console.WriteLine("   b.- Media de Números.");
            Console.WriteLine("   c.- Contar Vocales.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   d.- Mostrar código ASCII. No evaluar.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("   s.- Salir.");
            Console.WriteLine();
            Console.CursorLeft += 3;
            Console.Write("Opción: ");
        }

        /// <summary>
        /// Convierte el número entero a letras
        /// </summary>
        /// <param name="numero">Número que se quiere mostrar en letras</param>
        /// <returns>Devuelve un string con el valor en letras del número</returns>
        static string NumerosALetras(int numero)
        {
            switch (numero)
            {
                case 0:
                    return "CERO";
                case 1: 
                    return "UNO";
                case 2: 
                    return "DOS";
                case 3: 
                    return "TRES";
                case 4: 
                    return "CUATRO";
                case 5: 
                    return "CINCO";
                case 6: 
                    return "SEIS";
                case 7: 
                    return "SIETE";
                case 8: 
                    return "OCHO";
                case 9: 
                    return "NUEVE";
            }
            return "";
        }

        /// <summary>
        /// Cuenta cuantas veces aparece un vocal en un string
        /// </summary>
        /// <param name="texto">string en el que se va a contar</param>
        /// <param name="vocal">el vocal a contar</param>
        /// <returns>Devuelve la cantidad de veces que aparece el vocal</returns>
        static int ContarVocales(string texto, char vocal)
        {
            // Utilizo el metodo Count y dentro una expresión lambda para contabilizar cada vocal
            return texto.Count<char>(x => x == vocal); 
        }
    }
}
