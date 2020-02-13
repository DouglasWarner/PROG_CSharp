using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class CFechas
    {
        private int dia;
        private int mes;
        private int anio;
        private bool bisiesto;

        public int Dia
        {
            get { return dia; }
            set 
            {
                dia = ComprobarDiasDelMes(value);
            }
        }
        public int Mes
        {
            get { return mes; }
            set 
            {
                if (value < 1 && value > 12)
                    mes = 0;

                mes = value;
            }
        }
        public int Anio
        {
            get { return anio; }
            set 
            {
                if (value < 1 && value > 3000)
                    anio = 0;
                else
                {
                    anio = value;
                    bisiesto = EsAnioBisiesto();
                }
            }
        }

        public CFechas()
        {

        }


        public bool ValidarFecha()
        {
            if (Anio == 0 || Mes == 0 || Dia == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t La fecha es incorrecta.");
                Console.ResetColor();
                return false;
            }

            Console.WriteLine("\n\n\t La fecha con formato corto, es correcta {0}", this);
            Console.WriteLine("\n\n\t La fecha con formato largo, es correcto {0:00} de {1:00} del {2:0000}", Dia, Mes, Anio);
            if (bisiesto)
                Console.WriteLine("\n\t Ademas el año es bisiesto.");
            return true;
        }
        /// <summary>
        /// Comprueba si la fecha pasada es correcta.
        /// </summary>
        /// <param name="d">Dia</param>
        /// <param name="m">Mes</param>
        /// <param name="a">Año</param>
        /// <returns>Devuelve true si es valido, false por lo contrario</returns>
        public bool ValidarFecha(int d, int m, int a)
        {
            try
            {
                Anio = a;
                Mes = m;
                Dia = d;

                if (Anio == 0 || Mes == 0 || Dia == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t La fecha es incorrecta.");
                    Console.ResetColor();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t {0}", e.Message);
                Console.WriteLine("\n\t La fecha es incorrecta.");
                Console.ResetColor();
                return false;
            }

            Console.WriteLine("\n\n\t La fecha con formato corto, es correcta {0}", this);
            Console.WriteLine("\n\n\t La fecha con formato largo, es correcto {0:00} de {1:00} del {2:0000}", Dia, Mes, Anio);
            if(bisiesto)
                Console.WriteLine("\n\t Ademas el año es bisiesto.");
            return true;
        }

        public bool ValidarFecha(string fecha)
        {
            try
            {
                char[] separadores = { '-', '/' };
                string[] tmp = fecha.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                if (tmp.Length == 3)
                {
                    Anio = int.Parse(tmp[2]);
                    Mes = int.Parse(tmp[1]);
                    Dia = int.Parse(tmp[0]);
                }

                if (Anio == 0 || Mes == 0 || Dia == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t La fecha es incorrecta.");
                    Console.ResetColor();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t {0}", e.Message);
                Console.ResetColor();
                return false;
            }

            Console.WriteLine("\n\n\t La fecha con formato corto, es correcta {0}", this);
            Console.WriteLine("\n\n\t La fecha con formato largo, es correcto {0:00} de {1:00} del {2:0000}", Dia, Mes, Anio);
            if (bisiesto)
                Console.WriteLine("\n\t Ademas el año es bisiesto.");
            return true;
        }

        private bool EsAnioBisiesto()
        {
            return ((this.anio % 4 == 0 && !(this.anio % 100 == 0)) || (this.anio % 400 == 0)) ? true : false;
        }

        private int ComprobarDiasDelMes(int dia)
        {
            switch (this.mes)
            {
                case 1 | 3 | 5 | 7 | 8 | 10 | 12:
                    if (dia > 0 && dia <= 31)
                        return dia;
                    else
                        return 0;
                case 2:
                    if (bisiesto && (dia > 0 && dia <= 29))
                        return dia;
                    if (!bisiesto && (dia > 0 && dia <= 28))
                        return dia;
                    else
                        return 0;
                default:
                    if (dia > 0 && dia <= 30)
                        return dia;
                    else
                        return 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0:00}-{1:00}-{2:0000}", Dia, Mes, Anio);
        }
    }
}
