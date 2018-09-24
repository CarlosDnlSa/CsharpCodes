using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaI = 0, con = 0, sumaP = 0;

            //Solicitando el número de filas
            Console.Write("Ingrese el número de filas de la matriz: ");
            int f = int.Parse(Console.ReadLine());
            //Solicitando el número de columnas
            Console.Write("Ingrese el número de columnas de la matriz: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            //Rellenando la matriz
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Ingrese los datos de la matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Sacando los datos
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i % 2 != 0) //Sumando filas inpares
                    {
                        sumaI = sumaI + matriz[i, j];
                    }
                    if (j % 2 == 0)  //Sumando filas pares
                    {
                        sumaP = sumaP + matriz[i, j];
                    }
                    if (matriz[i, j] == 0)  //Contando los ceros en la matriz
                    {
                        con++;
                    }
                    //Falta sumar la diagonal inversa
                }
            }

            //Imprimiendo la matriz
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
                Console.WriteLine();
            }

            //Imprimiendo los datos
            Console.WriteLine("Suma de cada fila inpar: " + sumaI);
            Console.WriteLine("Total de ceros en la matriz: " + con);
            Console.WriteLine("Suma de cada columna par: " + sumaP);
            Console.ReadKey();
        }
    }
}
