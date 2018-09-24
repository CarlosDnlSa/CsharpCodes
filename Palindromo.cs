using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comp = false;
            string newString = "";
            string inputString;
            int total;

            Console.WriteLine("Ingrese el texto");
            inputString = Console.ReadLine();

            Console.WriteLine(inputString.Length);
   
            for (int i = inputString.Length-1; i >= 0; i--)
            {
                newString = newString + inputString[i];
            }
            Console.WriteLine(newString);
            if (inputString == newString)
            {
                comp = true;
            }


            Console.WriteLine(comp);
            Console.ReadKey();
        }
    }
}
