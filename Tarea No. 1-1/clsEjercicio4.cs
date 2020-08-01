using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class clsEjercicio4
    {

        public void Ejecuta()
        {
            decimal MontoEnPesos = 0.0M;
            decimal MontoEnDolares = 0.0M;
            decimal TasaDeCambio = 57.65M;
            decimal CampoValidacion = 0.0M;
            string strEntrada = "";

            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Calculo Cambiario RD$->US$");
            Console.WriteLine("--------------------------\n\n");

            Console.WriteLine("Entre el Monto en RD$");
            if (decimal.TryParse(Console.ReadLine(), out CampoValidacion))
            {
                if (CampoValidacion > 0)
                {
                    MontoEnPesos = CampoValidacion;
                }
            }

            Console.WriteLine($"Entre La Tasa de Cambio(Actual-RD${TasaDeCambio.ToString("C")} x US$1.00)");
            if (decimal.TryParse(Console.ReadLine(), out CampoValidacion))
            {
                if (CampoValidacion > 0)
                {
                    TasaDeCambio = CampoValidacion;
                }
            }

            MontoEnDolares = MontoEnPesos / TasaDeCambio;

            Console.WriteLine($"\n\nRD${MontoEnPesos.ToString("C")} es US${MontoEnDolares.ToString("C")} a la Tasa Actual de {TasaDeCambio} x US$1.00");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }



    }
}
