using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace Ejercicio15
{
    class GestionArticulo
    {
        string _fichero;

        public string Fichero
        {
            get { return _fichero; }
            set { _fichero = value; }
        }

        public GestionArticulo()
        {
            Fichero = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "datosArticulos.txt";
        }

        #region MyMethods
        
        public string GenerarHtml()
        {
            // DEVUELVE: La ruta del fichero html o un string vacio si no se creó.
            int nLinea = 1;
            string ficheroHTML = Path.ChangeExtension(Fichero, "html");
            Articulo tmp = null;
            StringBuilder docHtml = new StringBuilder();
            if (!File.Exists(Fichero))
                return "";
            
            // Cabecera de la tabla
            docHtml.Append("<html>");
            docHtml.Append("<head>");
            docHtml.Append("<title>Listado de Articulos</title>");
            docHtml.Append("</head>");
            docHtml.Append("<body>");
            docHtml.Append("<h1>Listado de Personas</h1>");
            docHtml.Append("<table border='1'>");
            docHtml.Append("<tr bgcolor='black' style=\"color: white;\"> <th>Orden</th> <th>Nombre</th> <th>Precio</th> <th>PVP</th> <th>Existencias</th> <th>Comentario</th> </tr>");

            // Cuerpo de la tabla
            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formate = new BinaryFormatter();
                while (flujo.Position < flujo.Length)
                {
                    try
                    {
                        tmp = (Articulo)formate.Deserialize(flujo);
                        if (tmp.Borrado)
                            continue;
                        if (nLinea % 2 == 0)
                            docHtml.Append("<tr bgcolor='white'>");
                        else
                            docHtml.Append("<tr bgcolor='gray'>");
                        docHtml.Append("<td>" + nLinea++.ToString("000") + "</td>");
                        docHtml.Append("<td>" + tmp.NombreArticulo.ToUpper() + "</td>");
                        docHtml.Append("<td>" + tmp.Precio.ToString("C", CultureInfo.GetCultureInfo("es-ES")) + "</td>");
                        docHtml.Append("<td>" + tmp.Pvp.ToString("C", CultureInfo.GetCultureInfo("es-ES")) + "</td>");
                        docHtml.Append("<td>" + tmp.Existencias.ToString("000") + "</td>");
                        docHtml.Append("<td>" + tmp.Comentario.ToUpper() + "</td>");
                        docHtml.Append("</tr>");
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            // Fin del cuerpo de la tabla
            docHtml.Append("</table></body></html>");

            // Crear el fichero de salida ...
            using (FileStream flujo = new FileStream(ficheroHTML, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(flujo, Encoding.Default))
                {
                    sw.Write(docHtml.ToString());
                }
            }
            return ficheroHTML;
        }
        
        public bool Anadir(string nombreArticulo, float precio, int existencias, string comentario)
        {
            IFormatter formato = new BinaryFormatter();
            Articulo articulo = new Articulo(nombreArticulo, precio, existencias, comentario);

            using (FileStream flujo = new FileStream(Fichero, FileMode.Append, FileAccess.Write))
            {
                formato.Serialize(flujo, articulo);
            }

            return true;
        }

        public void AnadirVariosArticulos(int nArticulos)
        {
            string[] nombreArticulo = { "The Promised Neverland 5",
                                        "The Promised Neverland 1",
                                        "Dr. Stone 1",
                                        "Dr. Stone 12",
                                        "The Boys 1",
                                        "Akira 1",
                                        "La Tumba de las luciérnagas" };
            string[] comentarios = { "Parte 5 del manga donde unos niños deciden escaparse del orfanato",
                                     "Orfanto en el los niños deciden espacarse",
                                     "Mundo post apocalíptico en el que todas las personas acabaron petrificadas",
                                     "Parte 12 del manga donde todo el mundo acaba petrificada",
                                     "Novela que adapta la situación social actual con un mundo donde la gente con superpoderes existen",
                                     "Joven con poderes de telepatía es perseguido por las calles de Tokio",
                                     "Novela que retrata la tragedia de la guerra japonesa en la piel de dos hermanos" };

            Random rnd = new Random();
            
            for (int i = 0; i < nArticulos; i++)
            {
                int tmpRandom = rnd.Next(nombreArticulo.Length);

                Anadir(nombreArticulo[tmpRandom], (float)rnd.NextDouble() * 100, rnd.Next(1, 50), comentarios[tmpRandom]);
            }
        }

        public void Listar()
        {
            int contador = 1;
            int maxListaVisualizado = 20;
            List<Articulo> listado = new List<Articulo>();

            if (!File.Exists(Fichero))
            {
                Console.Write("No hay datos a listar. El fichero {0} no existe...", Fichero);
                Console.ReadLine();
                return;
            }

            Articulo tmp = null;
            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();
                
                while (true)
                {
                    try
                    {
                        tmp = (Articulo)formato.Deserialize(flujo);
                        if (tmp.Borrado)
                            continue;
                        listado.Add(tmp);
                    }
                    catch
                    {
                        // Se terminó el fichero
                        break;
                    }
                }

                Console.WriteLine("".PadLeft(85, '-'));
                Console.WriteLine("{0}{1}{2}{3}{4}", "Orden", "Nombre".PadLeft(10), "Precio".PadLeft(31), "PVP".PadLeft(18), "Existencias".PadLeft(19));
                Console.WriteLine("".PadLeft(85, '-'));

                foreach (Articulo item in listado)
                {
                    Console.WriteLine("{0}     {1}", contador++.ToString("000").PadLeft(2), item.ToString());
                    if (contador == maxListaVisualizado)
                    {
                        Console.WriteLine("".PadLeft(85, '-'));
                        Console.WriteLine("Pulsa [a] para visualiar los siguientes 20 articulos \t Pulsa cualquier tecla para volver.");
                        if (Console.ReadKey(true).Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.WriteLine("".PadLeft(85, '-'));
                            Console.WriteLine("{0}{1}{2}{3}{4}", "Orden", "Nombre".PadLeft(10), "Precio".PadLeft(31), "PVP".PadLeft(18), "Existencias".PadLeft(19));
                            Console.WriteLine("".PadLeft(85, '-'));
                            maxListaVisualizado += 20;
                            continue;
                        }
                        else
                            return;
                    }
                }
                Console.WriteLine("".PadLeft(85, '-'));
                Console.WriteLine("Fin del listado \t\t Pulsa cualquier tecla para volver.");
                Console.ReadLine();
            }
        }

        public void ListarOrdenadoPorNombre()
        {
            int contador = 1;
            int maxListaVisualizado = 20;
            List<Articulo> ordenadoPorNombre = new List<Articulo>();

            if (!File.Exists(Fichero))
            {
                Console.Write("No hay datos a listar. El fichero {0} no existe...", Fichero);
                Console.ReadLine();
                return;
            }

            Articulo tmp = null;
            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();
                while (true)
                {
                    try
                    {
                        tmp = (Articulo)formato.Deserialize(flujo);
                        if (tmp.Borrado)
                            continue;
                        ordenadoPorNombre.Add(tmp);
                    }
                    catch
                    {
                        break;
                    }
                }

                Console.WriteLine("".PadLeft(85, '-'));
                Console.WriteLine("{0}{1}{2}{3}{4}", "Orden", "Nombre".PadLeft(10), "Precio".PadLeft(31), "PVP".PadLeft(18), "Existencias".PadLeft(19));
                Console.WriteLine("".PadLeft(85, '-'));

                foreach (Articulo item in ordenadoPorNombre.OrderBy(x=> x.NombreArticulo))
                {
                    Console.WriteLine("{0}     {1}", contador++.ToString("000").PadLeft(2), item.ToString());
                    if (contador == maxListaVisualizado)
                    {
                        Console.WriteLine("".PadLeft(85, '-'));
                        Console.WriteLine("Pulsa [a] para visualiar los siguientes 20 articulos \t Pulsa cualquier tecla para volver.");
                        if (Console.ReadKey(true).Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.WriteLine("".PadLeft(85, '-'));
                            Console.WriteLine("{0}{1}{2}{3}{4}", "Orden", "Nombre".PadLeft(10), "Precio".PadLeft(31), "PVP".PadLeft(18), "Existencias".PadLeft(19));
                            Console.WriteLine("".PadLeft(85, '-'));
                            maxListaVisualizado += 20;
                            continue;
                        }
                        else
                            return;
                    }
                }
                Console.WriteLine("".PadLeft(85, '-'));
                Console.WriteLine("Fin del listado \t\t Pulsa cualquier tecla para volver.");
                Console.ReadLine();
            }
        }

        public long Buscar(int codigo)
        {
            long PosArticuloAnterior = 0;
            long PosArticuloActual = 0;

            if (!File.Exists(Fichero))
                return -1;

            Articulo tmp = null;
            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();
                while (true)
                {
                    try
                    {
                        PosArticuloAnterior = flujo.Position;
                        tmp = (Articulo)formato.Deserialize(flujo);

                        if (tmp.Codigo == codigo && !tmp.Borrado)
                        {
                            PosArticuloActual = flujo.Position;
                            return PosArticuloAnterior;
                        }
                    }
                    catch
                    {
                        return -1;
                    }
                }

                return -1;
            }
        }

        public bool Borrar(long PosArticuloBorrar)
        {
            if (PosArticuloBorrar == -1)
                return false;

            Articulo tmp = null;

            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.ReadWrite))
            {
                IFormatter formato = new BinaryFormatter();
                flujo.Position = PosArticuloBorrar;
                tmp = (Articulo)formato.Deserialize(flujo);
                tmp.Borrado = true;
                flujo.Position = PosArticuloBorrar;
                formato.Serialize(flujo, tmp);
            }

            return true;
        }

        public bool Consultar(long PosArticuloConsultar)
        {
            if (PosArticuloConsultar == -1)
                return false;

            Articulo tmp = null;

            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();
                flujo.Position = PosArticuloConsultar;
                tmp = (Articulo)formato.Deserialize(flujo);
                if (tmp.Borrado)
                    return false;
                else
                {
                    tmp.MostrarArticuloConComentario();
                    return true;
                }
            }
        }
        
        public bool Modificar(long PosArticuloModificar, string nombre, float precio, int existencias, string comentario)
        {
            if (PosArticuloModificar == -1)
                return false;

            Articulo tmp = null;

            using (FileStream flujo = new FileStream(Fichero, FileMode.Open, FileAccess.ReadWrite))
            {
                IFormatter formato = new BinaryFormatter();
                flujo.Position = PosArticuloModificar;
                tmp = (Articulo)formato.Deserialize(flujo);
                tmp.NombreArticulo = nombre;
                tmp.Precio = precio;
                tmp.Existencias = existencias;
                tmp.Comentario = comentario;
                flujo.Position = PosArticuloModificar;
                formato.Serialize(flujo, tmp);
            }

            return true;
        }
        #endregion
    }
}
