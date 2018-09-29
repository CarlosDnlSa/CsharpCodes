using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegiatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double CostoM, NmaterC, PromE = 0, TotalR = 0, TotalI = 0;
            String NombreE;
            Boolean band = true;


            EstAlumnos EstAl = new EstAlumnos();
            CostoM = EstAl.Cargar();

            while(band == true)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                NombreE = Console.ReadLine();

               

                if (EstAl.Comprobar(NombreE) == false)
                {
                    Console.WriteLine(EstAl.Mensaje());
                    break;
                }

                Console.Write("Número de materias a cursar: ");
                NmaterC = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el promedio del estudiante: ");
                PromE = double.Parse(Console.ReadLine());

                Console.WriteLine(NombreE + " debe pagar " + EstAl.Calcular(CostoM, NombreE, NmaterC, PromE));
                TotalR = EstAl.TotalRec(CostoM, PromE, NmaterC);
                TotalI = EstAl.TotalIVA(CostoM, PromE, NmaterC);
            }


            Console.WriteLine();
            Console.WriteLine("El total recaudado por la universidad fue de: " + TotalR);
            Console.WriteLine("El total para impuestos es de: " + TotalI);
            Console.WriteLine("La ganancia total fue de: " + EstAl.Ganancia(TotalR, TotalI));
            Console.ReadKey();
        }
    }
}
