using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_16_12
{
    class Naipe
    {
        public enum Palos
        {
            oro, espada, copas, basto
        }

        string[] nombres = { "", "As", "Dos", "Tres", "Cuatro", "Cinco", "seis", "siete", "ocho", "nueve", "sota", "caballo", "rey" };

        string _nombre; // Nombre popular
        Palos _palo;    // El palo de la carta
        int _valor;     // Valor desde el 1 al 12
        float _peso;    // Valor en el juego
        string _comentario;     // Lo que me de la gana

        public Naipe(Palos p, int v)
        {
            _palo = p;
            _valor = v;

            _nombre = nombres[_valor] + " - " + _palo.ToString();
        }

        public string[] Formatear()
        {
            string[] formateada = {"        Nombre: " + _nombre,
                                   "          Palo: " + _palo.ToString(),
                                   "         Valor: " + _valor,
                                   "          Peso: " + _peso,
                                   "    Comentario: " + _comentario};

            return formateada;
        }

        public string Info()
        {
            return _nombre;
        }
    }
}
