using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, opcion;
            int[] vector;
            Operaciones oper = new Operaciones();
            vector = oper.Cargar(oper.Limite());
            Console.Clear();
            Console.WriteLine("Ingrese lo que quiere comprobar del conjunto");
            Console.WriteLine("1.- Saber si es par" + "\n" +"2.- Saber si es primo" + "\n" + "3.- Saber si es perfecto" + "\n" + "4.- Aplicar todas opciones");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    oper.Par(vector);
                break;
                case 2:
                    oper.Primo(vector);
                break;
                case 3:
                    oper.Perfecto(vector);
                break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("--Comprobando Pares");
                    oper.Par(vector);
                    Console.WriteLine();
                    Console.WriteLine("--Comprobando primos");
                    oper.Primo(vector);
                    Console.WriteLine();
                    Console.WriteLine("--Comprobando perfectos");
                    oper.Perfecto(vector);
                    break;
                default:
                    Console.Write("Opcion no válida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
