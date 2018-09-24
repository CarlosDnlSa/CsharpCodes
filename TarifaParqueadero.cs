using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2400, Adic = 600, TarMax = 6000, placa = 000, horas = 0, totalR = 0, diferencia = 0, valorPagar = 0;
            
            Console.WriteLine("Ingrese 000 para salir");
            do
            {
                Console.Write("Ingrese la placa del vehiculo: ");
                placa = int.Parse(Console.ReadLine());

                if (placa != 000)
                {
                    Console.Write("Ingrese el número de horas: ");
                    horas = int.Parse(Console.ReadLine());

                    if (horas == 0)
                    {
                        Console.WriteLine("El 0 no es una hora válida");
                    }
                    if (horas > 0 && horas <= 2)
                    {
                    
                        valorPagar = n;
                        Console.WriteLine("El valor a pagar es: " + valorPagar);
                    }
                    if (horas > 2 && horas < 24)
                    {
                        
                        diferencia = horas - 2;
                        valorPagar = n + Adic * (diferencia * 2);
                        Console.WriteLine("El valor a pagar es: " + valorPagar);
                    }
                    if (horas == 24)
                    {
                        
                        valorPagar = 6000;
                        Console.WriteLine("El valor a pagar es: " + valorPagar);
                    }
                    if (horas > 24)
                    {
                        Console.WriteLine("Supero el límite");
                    }

                     totalR = totalR + valorPagar;
                }
            } while (placa != 000);

            Console.WriteLine("Total recaudado " + totalR);
            Console.ReadKey();
        }
    }
}
