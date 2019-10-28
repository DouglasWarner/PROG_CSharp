using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        /*  Escribir en C# un programa que lea por teclados números hasta introducir un 0, que sume los pares e
            imprima su cuadrado, sume los impares y muestre la media.
        */
        static void Main(string[] args)
        {
            string tmp = string.Empty;
            int numero = 0;
            int sumPar = 0;
            int sumImpar = 0;
            int cantImpar = 0;

            Console.WriteLine("Esta aplicación va a calcular el cuadrado de la suma de todos los numeros pares introducidos por teclado. Y la media de los numeros impares.");
            Console.WriteLine("Introduce numeros hasta introducir un 0.");

            do
            {
                tmp = Console.ReadLine();
                if (!int.TryParse(tmp, out numero))
                {
                    Console.WriteLine("Porfavor introduce un numero");
                }
                else
                {
                    if (numero % 2 == 0)
                        sumPar += numero;
                    if (numero % 2 == 1)
                    {
                        sumImpar += numero;
                        cantImpar++;
                    }
                }

            } while(tmp != "0");

            Console.WriteLine("La suma de los numeros pares: {0}", sumPar);
            Console.WriteLine("El cuadrado de los numeros pares: {0}", Math.Pow(sumPar,2));
            Console.WriteLine("La suma de los numeros impares: {0}", sumImpar);
            Console.WriteLine("La media de los numeros impares: {0}", sumImpar / cantImpar);

            Console.ReadLine();
        }
    }
}
