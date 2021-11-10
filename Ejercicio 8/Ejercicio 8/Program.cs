using System;
using System.IO;

namespace ej
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var FileStream = new FileStream("C:/Users/boris/Desktop/UNIVERSIDAD/CICLO 2/PROGRAMACION ESTRUCTURADA/PARCIAL registro 3/Ejercicio 7/Ejercicio 8/fichero.txt", FileMode.CreateNew, FileAccess.Write))
            {
                using (var StreamWriter = new StreamWriter(FileStream))
                {
                    int num_est;

                    Console.WriteLine("Ingrese la cantidad de alumnos que se guardaran en el fichero: ");
                    num_est = Convert.ToInt32(Console.ReadLine());

                    string[] estudiantes = new string[num_est];

                    //cargar y visualizar una matriz
                    for (int i = 0; i < num_est; i++) //for para filas
                    {
                        int num_filas = i + 1;
                        Console.Write("Estudiante " + num_filas + ": ");
                        estudiantes[i] = Console.ReadLine();
                    }

                    //Visualizacion de matriz con datos ingresados
                    Console.WriteLine("\n********************** TABLA DE CONTROL *****************************\n");
                    for (int i = 0; i < num_est; i++)
                    {
                        Console.Write("\t" + estudiantes[i] + "\t");
                        StreamWriter.WriteLine(estudiantes[i]);
                    }
                    Console.Write("\n");
                }
            }

            using (var fs = new FileStream("C:/Users/boris/Desktop/UNIVERSIDAD/CICLO 2/PROGRAMACION ESTRUCTURADA/PARCIAL registro 3/Ejercicio 7/Ejercicio 8/fichero.txt", FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string todo = sr.ReadToEnd();
                Console.WriteLine(todo);
            }
        }
    }
}
