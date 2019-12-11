/*----------------------------------------------------------------------
 *   PROGRAMA: App_Ejercicio9
 *	    AUTOR: Douglas Warner Jurado Peña
 * 	    FECHA: 25/11/2019						VERSION: 1.0
 * COMENTARIO: Gestiona un array de una estructura de empleados.
 *---------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionEmpleado gEmp = new GestionEmpleado(10);
            GestionEmpleado.Empleado empleado = new GestionEmpleado.Empleado("Douglas", "Jurado", 40, 2000, "2010-11-21");
            GestionEmpleado.Empleado empleado2 = new GestionEmpleado.Empleado("Juan", "Paco", 40, 2000, "2010-11-21");

            gEmp.Anadir(empleado);
            gEmp.Anadir(empleado2);

            gEmp.Borrar(1);
            
            gEmp.Listar();
            Console.WriteLine("==========");
            gEmp.Anadir(empleado);

            gEmp.Listar();

            Console.WriteLine(" El empleado esta en la posicion " + gEmp.Buscar(2));
            if(gEmp.Buscar(4) == -1)
                Console.WriteLine("El empleado no se encuentra");

            Console.ReadLine();
        }
    }

    class miclase
    {
    }

}
