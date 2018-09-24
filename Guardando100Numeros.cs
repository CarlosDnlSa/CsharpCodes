using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guardando 100 números en un vector
            int[] vector = new int[100];

            for (int i = 0; i < 100; i++)
            {
                vector[i] = i;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
