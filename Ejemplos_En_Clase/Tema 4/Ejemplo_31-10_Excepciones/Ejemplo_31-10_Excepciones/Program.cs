using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_31_10_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerador = 0;
            int denominador = 0;
            double resultado = 0.0;

            try
            {
                Console.WriteLine(" Se cálcular una división muy dificil ");
                Console.Write(" Dime el numerador: ");
                numerador = int.Parse(Console.ReadLine());
                Console.Write("\n Dime el denominador: ");
                denominador = int.Parse(Console.ReadLine());

                resultado = numerador / denominador;

                Console.WriteLine("\n\n     El resultado de este pedaso de división entre esto {0} y esto {1} es esto: {2}",
                                    numerador, denominador, resultado);
            }
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine(dEx.Message + dEx.TargetSite);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            finally
            {
                Console.WriteLine("\n     Ere umakina aciendo divisione");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
