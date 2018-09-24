using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class Program
    {
        class Empleado
        {
            private string nombre;
            private int sueldo;

            public void Cargar()
            {
                Console.Write("Ingrese el nombre del Empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo del empleado: ");
                sueldo = int.Parse(Console.ReadLine());
            }

            public void Imprimir()
            {
                Console.WriteLine("El nombre del empleado es " + nombre);
                Console.WriteLine("El sueldo del trabajado es " + sueldo);
            }

            public void Impuestos()
            {
                if (sueldo > 3000){
                    Console.WriteLine("Si debe pagar impuestos");
                }
            }
        }
        static void Main(string[] args)
        {
            Empleado Em = new Empleado(); //Creando la instancia de la clase
            Em.Cargar();        //Invocando el método cargar
            Em.Imprimir();  //Invocando el método imprimir
            Em.Impuestos(); //Invocando el método impuestos
            Console.ReadKey();

        }
    }
}
