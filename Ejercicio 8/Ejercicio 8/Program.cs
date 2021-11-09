using System;
using System.IO;

namespace ej
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            using (var FileStream = new FileStream("C:/Users/boris/Desktop/UNIVERSIDAD/CICLO 2/PROGRAMACION ESTRUCTURADA/PARCIAL registro 3/Ejercicio 7/Ejercicio 8/fichero.txt", FileMode.CreateNew, FileAccess.Write))
            {
                using (var StreamWriter = new StreamWriter(FileStream))
                {
                    int i = 1, num_est;

                    Console.WriteLine("Ingrese la cantidad de alumnos que se guardaran en el fichero: ");
                    num_est = int.Parse(Console.ReadLine());

                    int[] estudiantes = new int[num_est];

                    //cargar y visualizar una matriz
                    for (int filas = 0; filas < num_est; filas++) //for para filas
                    {
                        int num_filas = filas + 1;
                        Console.Write("Estudiante " + num_filas + ": ");
                        estudiantes[num_est] = int.Parse(Console.ReadLine());
                    }

                    //Visualizacion de matriz con datos ingresados
                    Console.WriteLine("\n********************** TABLA DE CONTROL *****************************\n");
                    for (int filas = 0; filas < num_est; filas++)
                    {
                        Console.Write("\t" + estudiantes[num_est] + "\t");
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
