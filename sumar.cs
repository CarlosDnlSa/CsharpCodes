using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            retornas ret = new retornas();
            Console.Write("Ingrese el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());
            ret.Sumar(a, b);
            Console.Write("La suma es igual a: " + ret.Sumar(a,b));
            Console.ReadKey();
        }
    }
}
