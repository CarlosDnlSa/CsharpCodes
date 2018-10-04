using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f, c, reset = 0,j,min , con = 1;
            double  puntos = 0, Acumu = 0,aux;
            string auxT;
            //Vector de los aspectos a tener en cuenta
            string[] PuntosC = new string[5] { "Atención por parte de los empleados", "Calidad de los platillos", "Justicia del precio", "Ambiente general", "Recomendación a un conocido" };
            double[] Promedios = new double[5];
            //Matriz que almacenará las calificaciones
            double[,] matriz = new double[5, 10];

            //Pidiendo las calificaciones
            for (f = 0; f < 5; f++)
            {
                Acumu = 0;
                for (c = 0; c < 10; c++)
                { 
                    Console.Write(PuntosC[f] + " : ");
                    puntos = double.Parse(Console.ReadLine());
                    matriz[f, c] = puntos;
                    reset++;
                    Acumu = Acumu + matriz[f, c];
                }
                Promedios[f] = Acumu / 10;
            }
            Console.Clear();
           
            Console.WriteLine("--Promedios--");
            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.Write(PuntosC[i] + " : " + Promedios[i]);
                Console.WriteLine();
            }

            for (i = 0; i < Promedios.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < Promedios.Length; j++)
                    if (Promedios[j] < Promedios[min])
                    {
                        aux = Promedios[j];
                        Promedios[j] = Promedios[min];
                        Promedios[min] = aux;

                        auxT = PuntosC[j];
                        PuntosC[j] = PuntosC[min];
                        PuntosC[min] = auxT;
                    }
            }
            //Mayor a menor
            Console.WriteLine();
            Console.WriteLine("--Mejor calificado al peor calificado--");
            Console.WriteLine();
            for (i = 4; i >= 0; i--)
            {
                Console.Write(PuntosC[i] + " : " + Promedios[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
