using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12_03_Binario
{
    class Naipe
    {
        public int valor;      // Valor del naipe
        public string nombre;  // Texto con su nombre
        public float peso;     // Su valor para el juego de las siete y media
        public string palo;

        public override string ToString()
        {
            string sep = ";";
            return valor.ToString() +sep+palo+sep+peso.ToString()+sep+nombre+sep;
        }
    }
}
