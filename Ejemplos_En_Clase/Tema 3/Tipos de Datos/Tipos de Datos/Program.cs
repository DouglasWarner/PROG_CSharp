using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_Datos
{
	class Program
	{
		static void Main(string[] args)
		{
			/*							TIPOS DE DATOS
			 *			- POR VALOR
			 *			- POR REFERENCIA
			 */


			//							POR VALOR de la clase ValueType

			/*		ENTEROS
			 * byte (2^8) 8 bits, sbyte (-2^7 a 2^7-1) 7 bits y 1 bits reservador para el signo menos [-].
			 * short (-2^15 a 2^15-1) 15 bits y 1 bits reservador para el signo menos [-], ushort (2^16) 16 bits.
			 * int (-2^31 a 2^31-1) 31 bits y 1bits reservador para el signo menos [-], uint (2^32) 32 bits.
			 * long (-2^63 a 2^63-1) 63 bits y 1bits reservador para el signo menos [-], ulong (2^64) 64 bits.
			 * */
			byte b = 127;
			short s = 127;
			int i = 127;
			long l = 127;
			Console.WriteLine("Byte --> {0}\nShort --> {1}\nInt --> {2}\nLong --> {3}",b,s,i,l);

			/*		REALES (cualquier constante numerica que sea real, en .Net por defecto es double.
			 * float
			 * C# tambien acepta el tipo decimal.
			 * double --> capaz de almacenar 308 digitos.
			 * */
			float f = 127.127F;
			double d = 127.127;
			decimal deci = 127.127M;
			Console.WriteLine("Float --> {0}\nDouble --> {1}\nDecimal --> {2}", f,d, deci);

			// Bool (true/false)
			bool boleano = true;
			Console.WriteLine("Booleano --> {0}",boleano);
			// Char (2^16) 16 bits
			char caracter = 'c';
			Console.WriteLine("Char --> {0}", caracter);
			/* Enumeraciones
				enum MyEnum
				{
	         
				}
			 */
			/* Estructuras
				struct MyStruct
				{
		
				}
			*/

			//							POR REFERENCIA
			/* Clases
			 * Arrays
			 * String
			 * Interfaces
			 */

			

			Console.ReadLine();

		}
	}
}
