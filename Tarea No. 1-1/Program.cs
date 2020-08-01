using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu Tarea No. 1-1
            string strSeleccion = " ";
            int intSeleccion = 1;

            while (intSeleccion != 99)
            {
                Console.Clear();
                Console.WriteLine("Menu Tarea No. 1-1");
                Console.WriteLine("------------------");

                // Menu de ejercicios
                Console.WriteLine("1-Programa Calculo Perimetro Cuadrado");
                Console.WriteLine("2-Programa Calculo Masa de Aire");
                Console.WriteLine("3-Programa Calculo Salario Empleado");
                Console.WriteLine("4-Programa Calculo Cambiario RD$->US$");
                Console.WriteLine("5-Programa Calculo Porcentaje Estudiantes Femenino/Masculino");
                // 
                Console.Write("***Seleccione el Ejercicio a Ejecutar y Presione ENTER. (99-Salir)");

                strSeleccion = Console.ReadLine();

                if (strSeleccion.Length > 0)
                    intSeleccion = int.Parse(strSeleccion);
                else
                    intSeleccion = 0;
                //*********************************************
                // Seleccion de ejercicios
                //********************************************
                switch (intSeleccion)
                {
                    case 1: // Calculo Perimetro Cuadrado
                        clsEjercicio1 Ejercicio1 = new clsEjercicio1();
                        Ejercicio1.Ejecuta();
                        break;

                    case 2: // Programa Calculo Masa de Aire
                        clsEjercicio2 Ejercicio2 = new clsEjercicio2();
                        Ejercicio2.Ejecuta();
                        break;

                    case 3: // Programa Calculo Salario Empleado
                        clsEjercicio3 Ejercicio3 = new clsEjercicio3();
                        Ejercicio3.Ejecuta();
                        break;
                    case 4: // Programa Calculo Cambiario RD$->US$
                        clsEjercicio4 Ejercicio4 = new clsEjercicio4();
                        Ejercicio4.Ejecuta();
                        break;
                    case 5: // Calculo Porcentaje Estudiantes Femenino/Masculino
                        clsEjercicio5 Ejercicio5 = new clsEjercicio5();
                        Ejercicio5.Ejecuta();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }
            Console.Clear();
            Console.WriteLine("Bye...");










        }
    }
}
