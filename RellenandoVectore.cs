using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[10];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese los valores del  vector a ");
                int date_a = int.Parse(Console.ReadLine());

                a[i] = date_a;
                c[i] = date_a;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese los valores del vector b ");
                int date_b = int.Parse(Console.ReadLine());

                b[i] = date_b;
                for(int j = 0; j < 10; j++)
                {
                    if (a[i] != b[i])
                    {
                        c[j] = i;
                    }
                }
            }


            //Imprimiendo los vectores
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" " + a[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" " + b[i]) ;
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + c[i]);
            }

            Console.ReadLine();
        }
    }
}
