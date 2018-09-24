using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,i, horasT, valorT, salario, RI, SS, TSP = 0, TAI = 0, TASS = 0;
            String nombre;
            Console.WriteLine("Ingrese el número de trabajadores");
            n = double.Parse(Console.ReadLine());

            //Capturando los datos de cada trabajador
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Nombre del trabajador: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese las horas trabajadars: ");
                horasT = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de horas ");
                valorT = double.Parse(Console.ReadLine());

                salario = (horasT * valorT);
                if (salario >= 800000)
                {
                    RI = salario * 4.5 / 100;
                    SS = salario * 2.5 / 100;
                    salario = salario - RI - SS;
                }
                else
                {
                    SS = salario * 2 / 100;
                    RI = 0;
                    salario = salario - SS + 60000; 
                }

                TSP = TSP + salario;
                TASS = TASS + SS;
                TAI = TAI + RI;
                Console.WriteLine("El trabajador " + nombre + " tiene un salario de " + salario);
            }
            Console.WriteLine("Total de salarios pagados: " + TSP);
            Console.WriteLine("Total de aportes a Seguridad social: " + TASS);
            Console.WriteLine("Total retención de impuestos: " + TAI);
            Console.ReadKey();
        }
    }
}
