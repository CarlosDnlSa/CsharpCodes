using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    class Program
    {
        class Multiplicacion
        {
            int contF = 1, contC = 1, i = 0, j = 0;
            int[,] matriz = new int[15, 15];

            //Rellenando la matriz
            public void Cargar()
            {
                for (i = 0; i < 15; i++)
                {
                    matriz[0, i] = contC++;
                    matriz[i, 0] = contF++;
                }
            }
            public void Multiplicar()
            {
              for(i = 0; i < 15; i++)
                {
                    for(j = 0; j < 15; j++)
                    {
                        if (i != 0 && j != 0)
                        {
                            matriz[i, j] = matriz[0, j] * matriz[i, 0];
                        }
                    }
                }
            }

            public void Imprimir()
            {
                for (i = 0; i < 15; i++)
                {
                    for(j = 0; j < 15; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Multiplicacion mul = new Multiplicacion();
            mul.Cargar();
            mul.Multiplicar();
            mul.Imprimir();
            Console.ReadKey();
        }
    }
}
