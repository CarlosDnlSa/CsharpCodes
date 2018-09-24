using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        class sumar
        {
            private int n1, n2, n3;
            public void Ingresar()
            {
                Console.WriteLine("Ingrese el primer número");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                n2 = int.Parse(Console.ReadLine());
            }

            public void Sumar()
            {
                n3 = n1 + n2;
            }
            
            public void Imprimir()
            {
                Console.WriteLine("La suma es igual a: " + n3);
            }
        }
        static void Main(string[] args)
        {
            sumar su1 = new sumar();
            su1.Ingresar();
            su1.Sumar();
            su1.Imprimir();
            Console.ReadLine();
        }
    }
}
