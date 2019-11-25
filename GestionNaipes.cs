using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App__GestionNaipes
{
    class GestionNaipes
    {
        Random rnd = new Random();
        const int TAMANOBARAJA = 100;
        public enum Palos { Oro, Copa, Espada, Basto };
        public enum Valor { Uno = 1, Dos, Tres, Cuatro, Cinco, Seis, Siete, Sota=10, Caballo, Rey} ;
        public struct Naipe
        {
            Valor valor; // valor del naipe
            Palos palo;   //Pues eso, oro, copa,espada o bastos            
            //etc

            public Naipe(Palos p, Valor v)
            {
                valor = v;
                palo = p;

            }

            public void VerNaipe()
            {
                Console.Write("{0}, {1}", valor, palo);
            }
            //Etc.....
        }
        int Ndatos = 0;  //Nº de datos de la baraja

        Naipe[] Baraja = new Naipe[TAMANOBARAJA];


        public bool Anadir(Naipe naipe)
        {
            if (Ndatos == Baraja.Length)
                return false;
            Baraja[Ndatos++] = naipe;
            return true;
        }

        public void VerBaraja()
        {
            for (int i = 0; i < Ndatos; i++)
            {
                Baraja[i].VerNaipe();
                Console.WriteLine();
                
            }
        }

        public void AnadirNaipesAleatorios(int cuantos)
        {

            int valor ;       //Desde 1 a 12
            
            int palo;
            for (int i = 0; i < cuantos; i++)
            {
                valor = rnd.Next(12) + 1;
                if (valor == 8 || valor == 9)
                {
                    valor = 10;

                }
                palo = rnd.Next(4);
                Naipe naipe = new Naipe((Palos)palo, (Valor)valor);
                Anadir(naipe);
            }

            
        }


        public void Inicializar()
        {
            Ndatos = 0;
        }


    }
}
