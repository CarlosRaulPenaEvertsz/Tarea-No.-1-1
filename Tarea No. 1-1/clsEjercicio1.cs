using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class clsEjercicio1
    {

        public void Ejecuta()
        {
            int intLado = 0;
            int intPerimetro = 0;
            string strEntrada = "";

            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Calculo Perimetro de un Cuadrado");
            Console.WriteLine("--------------------------------\n\n");

            Console.WriteLine("Entre Valor de Un Lado");
            strEntrada = Console.ReadLine();
            intLado = int.Parse(strEntrada);

            intPerimetro = intLado * 4;
            
            Console.WriteLine($"\n\nPara un Cuadrado de Lado={intLado} el Perimetro={intPerimetro}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
