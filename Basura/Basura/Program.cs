﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Douglas.Ejercicio1;

namespace Basura
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal m = new MenuPrincipal("hhhh", new string[] { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaa" }, "holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", Tipo.Doble);

            m.MostrarMenu();

            m.MostrarMensaje("hola joio");

            Console.Clear();
            m.MostrarMenu(10, 50);

            Console.ReadLine();
        }
    }
}
