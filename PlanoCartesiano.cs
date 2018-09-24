using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoCartesiano
{
    class Program
    {
        class PlanoCartesiano{
            private int x, y;

            public void Cargar()
            {
                Console.Write("Ingrese el valor de x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de y: ");
                y = int.Parse(Console.ReadLine());
            }

            public void imprimir()
            {
                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Esta en el origen del plano cartesiano");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primer cuadrante");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo cuadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Tercer cuadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Cuarto cuadrante");
                }
            }

        }
        static void Main(string[] args)
        {
            PlanoCartesiano pla = new PlanoCartesiano(); //Creando una instancia de la clase
            pla.Cargar(); //Invocando el método cargar
            pla.imprimir(); //Invocando el método imprimir
            Console.ReadKey();
        }
    }
}
