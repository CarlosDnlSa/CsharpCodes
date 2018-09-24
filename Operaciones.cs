using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        class Operaciones
        {
            private int num1, num2, oper;
            private double operD, num1D, num2D; 
            public void Cargar()
            {
                Console.Write("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());
            }
            public void Sumar()
            {
                oper = num1 + num2;
                Console.WriteLine("La suma es igual a: " + oper);
            }
            public void Restar()
            {
                oper = num1 - num2;
                Console.WriteLine("La resta es igual a: " + oper);
            }
            public void Multiplicar()
            {
                oper = num1 * num2;
                Console.WriteLine("La multiplicación es igual a: " + oper);
            }
            public void Dividir()
            {
                num1D = num1;
                num2D = num2;
                operD = num1D / num2D;
                Console.WriteLine("La división es igual a: " + operD);
            }
        }   
        static void Main(string[] args)
        {
            Operaciones oper = new Operaciones(); //Creando la instancia de la clase
            oper.Cargar();
            oper.Sumar();
            oper.Restar();
            oper.Multiplicar();
            oper.Dividir();
            Console.ReadKey();
        }
    }
}
