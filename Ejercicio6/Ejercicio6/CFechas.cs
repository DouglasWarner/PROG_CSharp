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
                if (bisiesto && mes == 2 && (value > 0 && value <= 29))
                    dia = value;
                dia = ComprobarDiasDelMes(value);
            }
        }
        public int Mes
        {
            get { return mes; }
            set 
            {
                if (value < 1 && value > 12)
                    throw new Exception("Error: Mes incorrecto.");

                mes = value;
            }
        }
        public int Anio
        {
            get { return anio; }
            set 
            {
                if (value < 1 && value > 3000)
                    throw new Exception("Error: Año incorrecto. Solo esta permitido del año 1 al año 3000.");
                anio = value;
                bisiesto = EsAnioBisiesto();
            }
        }

        public CFechas()
        {

        }


        public bool ValidarFecha()
        {
            try
            {
                if (Anio == null || Mes == null || Dia == null)
                    return false;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t {0}", e.Message);
                Console.ResetColor();
                return false;
            }

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
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t {0}", e.Message);
                Console.WriteLine("\n\t La fecha es incorrecta.");
                Console.ResetColor();
                return false;
            }

            Console.WriteLine("\n\n\t La fecha es correcta {0}-{1}-{2}", Dia, Mes, Anio);
            if(bisiesto)
                Console.WriteLine("\t Ademas el año es bisiesto");
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
                        throw new Exception("Error: Dia incorrecto para dado el mes " + this.mes.ToString("00"));
                default:
                     if (dia > 0 && dia <= 30)
                        return dia;
                    else
                        throw new Exception("Error: Dia incorrecto para dado el mes " + this.mes.ToString("00"));
            }
        }
    }
}
