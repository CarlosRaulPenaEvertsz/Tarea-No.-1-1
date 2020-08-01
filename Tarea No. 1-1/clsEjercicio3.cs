using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class clsEjercicio3
    {
        public void Ejecuta()
        {
            decimal SueldoAnterior = 0.0M;
            decimal SueldoActual = 0.0M;
            decimal IncrementoPorcentual = 40.0M;
            decimal CampoValidacion = 0.0M;
            //string strEntrada = "";

            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Calculo Incremento Salario Empleado");
            Console.WriteLine("-----------------------------------\n\n");

            Console.WriteLine("Entre Sueldo Anterior");
            if (decimal.TryParse(Console.ReadLine(), out CampoValidacion))
            {
                if (CampoValidacion > 0)
                {
                    SueldoAnterior = CampoValidacion;
                }
            }

            Console.WriteLine($"Entre El Incremento en %({IncrementoPorcentual}%)");
            if (decimal.TryParse(Console.ReadLine(), out CampoValidacion))
            {
                if (CampoValidacion > 0)
                {
                    IncrementoPorcentual = CampoValidacion;
                }
            }

            SueldoActual = SueldoAnterior + SueldoAnterior * (IncrementoPorcentual / 100);

            Console.WriteLine($"\n\nEl Nuevo Sueldo es {SueldoActual}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
