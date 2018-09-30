using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMenu
{
    class Operaciones
    {
        int i, j;

        public int Limite()
        {
            int n;
            Console.Write("Total de numeros a guardar en el conjunto: ");
            n = int.Parse(Console.ReadLine());
            return n;
        }

        public int[] Cargar(int n)
        {
            int[] vector = new int[n];
            for (i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese los " + n + " números del conjunto: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        public void Par(int[] vector)
        {
            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    Console.WriteLine(vector[i] + " es par");
                }
                else
                {
                    Console.WriteLine(vector[i] + " es inpar");
                }
            }
        }
        public void Primo(int[] vector)
        {
            int cont = 0, pos = 0, s, div = 1,j;
            int[] conteo = new int[vector.Length];

            for (i = 0; i < vector.Length; i++)
            {
                cont = 0;
                for(j = 1; j < (vector[i] + 1); j++)
                {
                    if(vector[i] % j == 0)
                    {
                        cont++;
                    }
                }

            if (cont != 2)
            {
                Console.WriteLine(vector[i] + " no es primo");
            }
            else
            {
                Console.WriteLine(vector[i] + " es primo");
            }
            }
        }

        public void Perfecto(int[] vector)
        {
            int cont = 0, pos = 0, s, div = 1, j, sumar = 0;
            int[] conteo = new int[vector.Length];

            for (i = 0; i < vector.Length; i++)
            {
                sumar = 0;
                for (j = 1; j < (vector[i] + 1); j++)
                {
                    if (vector[i] % j == 0)
                    {
                        if (vector[i] != j)
                            sumar = sumar + j;
                    }
                }

                if (sumar == vector[i] && vector[i] != 0)
                {
                    Console.WriteLine(vector[i] + " es perfecto");
                }
                else if (vector[i] == 0)
                {
                    Console.WriteLine(vector[i] + " no estoy segura si es un número perfecto ");
                }
                else
                {
                    Console.WriteLine(vector[i] + " no es perfecto");
                }
            }
        }
        
    }
}
