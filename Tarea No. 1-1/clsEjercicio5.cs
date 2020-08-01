using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_No._1_1
{
    class clsEjercicio5
    {

        public void Ejecuta()
        {
            int CantEstudiantesF = 0;
            int CantEstudiantesM = 0;
            int TotalEstudiantes = 0;
            double PercentEstudiantesF = 0.0;
            double PercentEstudiantesM = 0.0;
            int CampoValidacion = 0; 
            
            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Calculo Porcentaje Estudiantes Femenino/Masculino");
            Console.WriteLine("-------------------------------------------------\n\n");

            Console.WriteLine("Entre La Cantidad de Estudiantes de Sexo Femenino en la Clase");
            if (int.TryParse( Console.ReadLine(), out CampoValidacion) ) 
            {
                if (CampoValidacion > 0)
                {
                    CantEstudiantesF = CampoValidacion;
                }
            }

            CampoValidacion = 0;
            Console.WriteLine("Entre La Cantidad de Estudiantes de Sexo Masculino en la Clase");
            if (int.TryParse(Console.ReadLine(), out CampoValidacion))
            {
                if (CampoValidacion > 0)
                {
                    CantEstudiantesM = CampoValidacion;
                }
            }
            TotalEstudiantes = CantEstudiantesF + CantEstudiantesM;
            if (TotalEstudiantes > 0)
            {
                PercentEstudiantesF = 100.0 * ((double)CantEstudiantesF / (double)TotalEstudiantes);
                PercentEstudiantesM = 100.0 * ((double)CantEstudiantesM / (double)TotalEstudiantes);
            }

            Console.WriteLine($"\n\nLa Clase está compuesta por un {PercentEstudiantesF.ToString("0.0")}% de Mujeres y un {PercentEstudiantesM.ToString("0.0")}% de Hombres");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }


    }
}
