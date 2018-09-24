using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int i = 0, j = 0, datos;
            
            //Diagonal principal
            for (i = 0; i < 5;i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Ingrese los datos de la matriz");
                    datos = int.Parse(Console.ReadLine());
                    matriz[i, j] = datos;
                    if (i == j)
                    {
                        matriz[i, j] = 0;
                    }
                }
            }
            //Diagonal secundaria
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                { 
                
                    if (i + j == 5 - 1)
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
