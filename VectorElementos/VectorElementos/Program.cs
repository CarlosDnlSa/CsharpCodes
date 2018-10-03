using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorElementos
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 vectorE = new Class1();
            vectorE.Cargar();
            vectorE.CopiandoV();
            vectorE.OrdenandoV();
            vectorE.Comparar();
            vectorE.Imprimir();
            Console.ReadKey();
  
        }
    }
}
