using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class clsEjercicio2
    {

        public void Ejecuta()
        {
            float MasaAire;
            float Presion;
            float VolumenAire;
            float Temperatura;

            string strEntrada = "";

            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Calculo Masa de Aire");
            Console.WriteLine("--------------------------------\n\n");

            Console.WriteLine("Entre La Presión");
            strEntrada = Console.ReadLine();
            Presion = float.Parse(strEntrada);

            Console.WriteLine("Entre el Volumen");
            strEntrada = Console.ReadLine();
            VolumenAire = float.Parse(strEntrada);

            Console.WriteLine("Entre la Temperatura");
            strEntrada = Console.ReadLine();
            Temperatura = float.Parse(strEntrada);

            MasaAire = (float)((Presion * VolumenAire) / ((float).37 * (Temperatura + 460)) );

            Console.WriteLine($"\n\nLa Masa del Aire es = {MasaAire}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
