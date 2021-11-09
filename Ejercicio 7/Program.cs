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

            //convertir a array 1d

            Console.WriteLine("\nconvertir a matriz 1d : \n");

            int k = 0;
            int zvalue = fil * col;
            int[] matriz1d = new int[zvalue];

            //total de datos para conv a 1d

            //convertir array 2d a 1d bajo el limite de filas * columnas, puesto que es 1d
            for (int filas = 0; filas < fil; filas++)
            {
                for (int columnas = 0; columnas < col; columnas++)
                {
                    matriz1d[k++] = orden[filas, columnas];
                }
            }
            for (int filas = 0; filas < fil * col; filas++)
            {
                Console.WriteLine("elemento[{0}] = {1} \t", filas, matriz1d[filas]);
            }

            //Resultados de ordenamiento
            Array.Sort(matriz1d);
            Array.Reverse(matriz1d);
            Console.WriteLine("\n******************DATOS EN ORDEN DESCENDENTE***************:\n");
            foreach (int value in matriz1d)
            {
                Console.Write(value + " ");
            }

        }
    }
}