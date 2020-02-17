using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12_02
{
    class InformeError : DivideByZeroException 
    {
        public override string Message
        {
            get
            {
                return "Error: Tienes que estudiar maquina";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numerador = 0;
            int denominador = 0;
            Console.WriteLine("\n     Soy un maquina dividiendo   ");
            Console.WriteLine("".PadLeft(40,'='));
            try
            {
                Console.Write("\n\t Dime el divisor: ");
                numerador = int.Parse(Console.ReadLine());

                Console.Write("\n\t Dime el dividendo: ");
                denominador = int.Parse(Console.ReadLine());

                //return;

                Console.Write("\n\n\t\t El resultado de la division: {0:2}", numerador / denominador);

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t ERROR: Solo de admiten números.");
                Console.ResetColor();
            }
            catch (DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t ERROR: Dividir por cero.");
                Informe(e);
                Console.ResetColor();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t ERROR: Número máximo permitido: {0}.", int.MaxValue);
                Console.ResetColor();
                return;
            }
            catch (ArgumentNullException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t ERROR: Al introducir el número.");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(e.Message);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("finaly");
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        static void Informe(Exception e)
        {
            Console.WriteLine("INFORMACION SOBRE LA EXCEPCION");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Mensaje: " + e.Message);
            Console.WriteLine(" Aplicacion: " + e.Source);
            Console.WriteLine(" Sitio: " + e.TargetSite);
            Console.WriteLine(" Tipo: " + e.GetType());
            Console.Write(" Pulse una tecla....");
            Console.ReadLine();
        }
    }
}
