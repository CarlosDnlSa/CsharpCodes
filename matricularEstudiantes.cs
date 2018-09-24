using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0,TotalM = 0, i = 0, TCM = 0;
            Console.Write("Ingrese el número de estudiantes a matricular: ");
            N = int.Parse(Console.ReadLine());

            int[] CodigoE = new int[N];
            int[] rentasL = new int[N];
            int[] Patrimonios = new int[N];
            int[] Vcredito = new int[N];
            int[] CredMat = new int[N];

            for (i = 0; i < N; i++)
            {
                TCM = 0;
                Console.Write("Ingrese el código del estudiante: ");
                CodigoE[i] = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la renta del estudiante: ");
                rentasL[i] = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el patrimonio del estudiante: ");
                Patrimonios[i] = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el total de creditos a matricular: ");
                TCM = int.Parse(Console.ReadLine());

                if(rentasL[i] <= 25000 || Patrimonios[i] <= 100000)
                {
                    Vcredito[i] = 130000;
                }
                else
                {
                    if(rentasL[i] > 25000 && rentasL[i] < 30000 || Patrimonios[i] > 100000 && Patrimonios[i] <= 150000)
                    {
                        Vcredito[i] = 200000;
                    }
                    else
                    {
                        if (rentasL[i] > 30000 && rentasL[i] <= 40000 ||Patrimonios[i] > 150000 && Patrimonios[i] <= 210000)
                        {
                            Vcredito[i] = 280000;
                        }
                    }
                }

                CredMat[i] = TCM * Vcredito[i];
                TotalM = TotalM + CredMat[i];
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Para el estudiante de código: " + CodigoE[i]);
                Console.WriteLine("Total a pagar de: " + CredMat[i]);
                
            }
            Console.WriteLine("El total recaudado por matriculas fue: " + TotalM);
            Console.ReadKey();

        }
    }
}
