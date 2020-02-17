using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//----------------------------------------------------------
//      LIBRERIA NECESARIA PARA TRABAJAR CON FICHEROS
//----------------------------------------------------------
using System.IO;

namespace Ejemplo_17_02_ConceptosFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PATH
            EjemploPath();
            #endregion

            // STREAM

            // BINARYREADER / WRITER
            
            // BUFFEREDSTREAM
            
            // DIRECTORY

            // DIRECTORYINFO

            // DRIVEINFO
            
            // FILE
            
            // FILEINFO
            
            // FILESTREAM

            // STREAMREADER / WRITER
        }

        static void EjemploPath()
        {
            // Path.DirectorySeparatorChar --> El separador de directorio del sistema operativo actual.
            // Path.PathSeparator --> Separador de entre varias rutas.
            // Path.VolumeSeparatorChar --> el primer separador de las rutas dependiendo del sistema operativo.

            string ruta = Path.DirectorySeparatorChar+"datos"+Path.DirectorySeparatorChar+"datos.dat";
            string ruta1 = @"C:\mio\datos.dat";

            string extension = Path.ChangeExtension(ruta1, "000");

            Console.WriteLine(" RUTA: " + ruta);
            Console.WriteLine(" RUTA1: " + ruta1);
            Console.WriteLine(" Extension cambia: " + extension);

            Console.ReadLine();
        }
    }
}
