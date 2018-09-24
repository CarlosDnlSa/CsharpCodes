using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    class Program
    {
        class Persona
        {
            string auxS;
            int Edad, NP, i, j, aux;
            string[] nombre;
            int[] edades;
            public void TDatos()
            {
                Console.Write("Ingrese el número de personas a guardar: ");
                NP = int.Parse(Console.ReadLine());
                nombre = new string[NP];
                edades = new int[NP]; 
            }
            //Cargando los nombres y las edades
            public void Cargar()
            {
                for (i = 0; i < NP; i++)
                {
                    Console.Write("Ingrese el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Ingrese la edad de " + nombre[i] + " :");
                    edades[i] = int.Parse(Console.ReadLine());
                }
            }
            //Ordenando el vector por método burbuja
            public void Ordenar()
            {
              for(i = 0; i < NP- 1; i++)
                {
                    if (edades[i] > edades[i + 1])
                    {
                        //Ordenando las edades
                        aux = edades[i];
                        edades[i] = edades[i + 1];
                        edades[i + 1] = aux;
                        //Ordenando los nombres
                        auxS = nombre[i];
                        nombre[i] = nombre[i + 1];
                        nombre[i + 1] = auxS;
                    }
                }
            }
            //Imprimiendo el vector
            public void Imprimir()
            {
                Console.WriteLine("--Datos ordenandos--");
                for (i = 0; i < NP; i++)
                {
                    Console.WriteLine(nombre[i] + " " + edades[i]);
                }
            }

            
        }
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.TDatos();
            per.Cargar();
            per.Ordenar();
            per.Imprimir();
            Console.ReadKey();
        }
    }
}
