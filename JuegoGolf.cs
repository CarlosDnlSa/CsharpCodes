using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando las variables 
            int f = 0, c = 18, i = 0, j = 0, Tpunt = 0,aux = 0, N = 0;
            string auxN = " ";
            Random punt = new Random(); //Método que me genera los numeros aleatoriamente

            //Pidiendo el número de jugadores
            Console.Write("Ingrese el número de jugadores: ");
            f = int.Parse(Console.ReadLine());

            string[] nombres = new string[f];
            int[] sumarP = new int[f];
            int[,] matriz = new int[f, c];

            //Rellenando el vector con los nombres
            for (i = 0; i < f; i++)
            {
                Console.Write("Nombres de los jugadores: ");
                nombres[i] = Console.ReadLine();
            }

            //Rellenando la matriz con el número de golpes
            Console.WriteLine("--La matriz se rellena automaticamente :D --");
            for (i = 0; i < f; i++)
            {
                Tpunt = 0;
                for (j = 0; j < c; j++)
                {
                    N = 0;
                    N = punt.Next(0, 15);
                    matriz[i, j] = N;
                    Tpunt = Tpunt + matriz[i,j];
                    sumarP[i] = Tpunt;
                }
            }
            for (i = 0; i < sumarP.Length; i++)
            {
                Console.WriteLine(sumarP[i]);
            }
            //Imprimiendo la matriz
            for (i = 0; i < f; i++)
            {
                for (j = 0; j < 18; j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
                Console.WriteLine();   
            }

            //Ordenando el vector de menor a mayor por método burbuja
            for (i = 1; i < sumarP.Length; i++)
            {
                for (j = 0; j < sumarP.Length - 1; j++)
                    if (sumarP[j] > sumarP[j + 1])
                    {
                        aux = sumarP[j];
                        sumarP[j] = sumarP[j + 1];
                        sumarP[j + 1] = aux;

                        auxN = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxN;
                    }
            }


            //Mostrando las posiciones
            Console.WriteLine("----Lista de posiciones----");

            for (i = 0; i < sumarP.Length; i++)
            {
                Console.WriteLine((i+1) + "-" + nombres[i] + " con " + sumarP[i]);
            }

      

            Console.ReadKey();
        }
    }
}
















