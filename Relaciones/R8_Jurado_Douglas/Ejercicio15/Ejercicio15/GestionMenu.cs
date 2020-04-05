using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------
using System.IO;
using Douglas.Ejercicio1;

namespace Ejercicio15
{
    class GestionMenu
    {
        const int POSX = 10;
        const int POSY = 10;
        const int ANCHO = 100;
        string titulo = "MENU PRINCIPAL";
        string[] opciones = {"1. Alta de artículos",
                             "2. Baja de artículos",
                             "3. Consultar un artículo",
                             "4. Modificar un artículo",
                             "5. Listar artículos ordenados por código",
                             "6. Listar artículos ordenador por nombre",
                             "7. Generar documento HTML",
                             "8. Crear fichero",
                             "0 - Para salir del programa" };
        string mensaje = "Selecciona una opción: ";
        MenuPrincipal m;
        GestionArticulo ga;

        public GestionMenu()
        {
            m = new MenuPrincipal(titulo, opciones, mensaje, Tipo.Simple);
            ga = new GestionArticulo();
            ga.AnadirVariosArticulos(10);
        }

        public void NavegarPorMenu()
        {
            string opcion = string.Empty;

            do
            {
                Console.Clear();
                m.MostrarMenu(POSX,POSY,ANCHO);
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AltaArticulo();
                        break;
                    case "2":
                        BajaArticulo();
                        break;
                    case "3":
                        ConsultarArticulo();
                        break;
                    case "4":
                        ModificarArticulo();
                        break;
                    case "5":
                        Console.Clear();
                        ga.Listar();
                        break;
                    case "6":
                        Console.Clear();
                        ga.ListarOrdenadoPorNombre();
                        break;
                    case "7":
                        ga.GenerarHtml();
                        break;
                    case "8":
                        if(File.Exists(ga.Fichero))
                        {
                            m.MostrarMensaje("El fichero ya existe. Se borrara y creara uno nuevo. ¿Estas seguro? s / n");
                            if (Console.ReadLine().ToLower() == "s")
                            {
                                FileStream fs = File.Create(ga.Fichero);
                                fs.Close();
                            }
                        }
                        break;
                    case "0":
                        m.MostrarMensaje("¿Seguro que quieres salir? s / n ");
                        opcion = Console.ReadLine();
                        if (opcion.ToLower() == "s")
                            return;
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private void AltaArticulo()
        {
            Console.Clear();

            string nombre = string.Empty;
            float precio = 0F;
            int existencias = 0;
            string comentario = string.Empty;

            Console.SetCursorPosition(POSX, POSY);
            Console.WriteLine("ALTA ARTICULO");
            Console.CursorLeft = POSX;
            Console.WriteLine("".PadLeft(50,'-'));
            Console.CursorLeft = POSX;
            Console.Write("\n Nombre articulo: ");
            nombre = Console.ReadLine();
            Console.CursorLeft = POSX;
            Console.Write("\n Precio: ");
            try
            {
                precio = float.Parse(Console.ReadLine());
            }
            catch
            {
                MostrarMensajeError("\n Error al introducir el precio");
                return;
            }
            Console.CursorLeft = POSX;
            Console.Write("\n Existencias articulo: ");
            try
            {
                existencias = int.Parse(Console.ReadLine());
            }
            catch
            {
                MostrarMensajeError("\n Error al introducir las existencias");
                return;
            }
            Console.CursorLeft = POSX;
            Console.Write("\n Comentario: ");
            comentario = Console.ReadLine();
            Console.CursorLeft = POSX;

            ga.Anadir(nombre, precio, existencias, comentario);

        }

        private void BajaArticulo()
        {
            Console.Clear();

            int codigoArticulo = 0;

            Console.SetCursorPosition(POSX, POSY);
            Console.WriteLine("BAJA ARTICULO");
            Console.CursorLeft = POSX;
            Console.WriteLine("".PadLeft(50, '-'));
            Console.CursorLeft = POSX;
            Console.Write("\n Codigo articulo: ");
            try
            {
                codigoArticulo = int.Parse(Console.ReadLine());
            }
            catch
            {
                MostrarMensajeError("\n Error al introducir el codigo");
                return;
            }

            long articuloBuscado = ga.Buscar(codigoArticulo);

            if (articuloBuscado != -1)
            {
                Console.CursorLeft = POSX;
                ga.Consultar(articuloBuscado);
                Console.CursorLeft = POSX;
                Console.Write("\n ¿Dar de baja? s / n");
                if (Console.ReadLine().ToLower() == "s")
                {
                    ga.Borrar(articuloBuscado);
                    Console.CursorLeft = POSX;
                    Console.WriteLine("\n Articulo dado de baja");
                }
            }
            else
                MostrarMensajeError("El articulo no se encuentra");
        }

        private void ConsultarArticulo()
        {
            Console.Clear();

            int codigoArticulo = 0;

            Console.SetCursorPosition(POSX, POSY);
            Console.WriteLine("CONSULTAR ARTICULO");
            Console.CursorLeft = POSX;
            Console.WriteLine("".PadLeft(50, '-'));
            Console.CursorLeft = POSX;
            Console.Write("\n Codigo articulo: ");
            try
            {
                codigoArticulo = int.Parse(Console.ReadLine());
            }
            catch
            {
                MostrarMensajeError("\n Error al introducir el codigo");
                return;
            }

            long articuloBuscado = ga.Buscar(codigoArticulo);

            if (articuloBuscado != -1)
            {
                Console.CursorLeft = POSX;
                ga.Consultar(articuloBuscado);
                Console.ReadLine();
            }
            else
                MostrarMensajeError("El articulo no se encuentra");
        }

        private void ModificarArticulo()
        {
            Console.Clear();

            string nombre = string.Empty;
            float precio = 0F;
            int existencias = 0;
            string comentario = string.Empty;

            int codigoArticulo = 0;

            Console.SetCursorPosition(POSX, POSY);
            Console.WriteLine("CONSULTAR ARTICULO");
            Console.CursorLeft = POSX;
            Console.WriteLine("".PadLeft(50, '-'));
            Console.CursorLeft = POSX;
            Console.Write("\n Codigo articulo: ");
            try
            {
                codigoArticulo = int.Parse(Console.ReadLine());
            }
            catch
            {
                MostrarMensajeError("\n Error al introducir el codigo");
                return;
            }

            long articuloBuscado = ga.Buscar(codigoArticulo);

            if (articuloBuscado != -1)
            {
                Console.CursorLeft = POSX;
                ga.Consultar(articuloBuscado);
            }
            else
            {
                MostrarMensajeError("El articulo no se encuentra");
                return;
            }
            Console.CursorLeft = POSX;
            Console.WriteLine("\n¿Modificar articulo? s / n");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.CursorLeft = POSX;
                Console.WriteLine("MODIFICAR ARTICULO");
                Console.CursorLeft = POSX;
                Console.WriteLine("".PadLeft(50, '-'));
                Console.CursorLeft = POSX;
                Console.Write("\n Nombre articulo: ");
                nombre = Console.ReadLine();
                Console.CursorLeft = POSX;
                Console.Write("\n Precio: ");
                try
                {
                    precio = float.Parse(Console.ReadLine());
                }
                catch
                {
                    MostrarMensajeError("\n Error al introducir el precio");
                    return;
                }
                Console.CursorLeft = POSX;
                Console.Write("\n Existencias articulo: ");
                try
                {
                    existencias = int.Parse(Console.ReadLine());
                }
                catch
                {
                    MostrarMensajeError("\n Error al introducir las existencias");
                    return;
                }
                Console.CursorLeft = POSX;
                Console.Write("\n Comentario: ");
                comentario = Console.ReadLine();
                Console.CursorLeft = POSX;

                ga.Modificar(articuloBuscado, nombre, precio, existencias, comentario);
            }
        }

        private void MostrarMensajeError(string mensaje)
        {
            Console.CursorTop--;
            Console.CursorLeft = POSX;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
