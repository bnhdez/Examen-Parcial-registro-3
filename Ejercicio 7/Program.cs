using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas que tendra la matriz: ");
            int fil = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas que tendra la matriz: ");
            int col = int.Parse(Console.ReadLine());

            int[,] orden = new int[fil, col];

            Console.WriteLine("Llene la matriz a continuacion\n");

            //cargar y visualizar una matriz
            for (int filas = 0; filas < fil; filas++) //for para filas
            {
                int num_filas = filas + 1;
                for (int columnas = 0; columnas < col; columnas++) // for interno para columnas
                {
                    int num_columnas = columnas + 1;
                    Console.Write("[Fila " + num_filas + ", columna " + num_columnas + "]: ");
                    orden[filas, columnas] = int.Parse(Console.ReadLine());

                }
            }

            //Visualizacion de matriz con datos ingresados
            Console.WriteLine("\n********************** TABLA DE CONTROL *****************************\n");
            for (int filas = 0; filas < fil; filas++)
            {
                for (int columnas = 0; columnas < col; columnas++)
                {
                    Console.Write("\t" + orden[filas, columnas] + "\t");
                }
                Console.Write("\n");
            }

            
        }
    }
}