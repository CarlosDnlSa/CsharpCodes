using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creando un archio
            TextWriter archivo;
            archivo = new StreamWriter("Informe.rft");
            string texto;
            texto = Console.ReadLine();
            archivo.WriteLine(texto);

            archivo.Close();
            Console.Clear();
            Console.WriteLine("El archivo ha sido creado exitosamente");


        }
    }
}
