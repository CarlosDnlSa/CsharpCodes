using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;//Declarando n que es el tamaño de la matriz
            Console.WriteLine("Ingrese el valor de la matriz N * N");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            //Rellenando la matriz
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("Ingrese los valores de la matriz: ");
                    int datos = int.Parse(Console.ReadLine());

                    matriz[f, c] = datos;
                }
            }

            //Primera y última fila por ceros
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f == 0 || f == n - 1 || c == 0 || c == n - 1)
                    {
                        matriz[f, c] = 0;
                    }
                   
                }
            }

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(" " + matriz[f, c]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
