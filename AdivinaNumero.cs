/*
 * Realizar un juego para adivinar un número. Para ello pedir un número N, y luego 
 * ir pidiendo números indicando “mayor” o “menor” según sea mayor o menor con respecto a N. 
 * El proceso termina cuando el usuario acierta.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoHerramientas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando las variables
            int N = 0, I = -1, con = 0, M;
            bool band = true;
            //Mostrando las opciones de juego
            Console.WriteLine("Modos de juego: ");
            Console.WriteLine("1- Ingresar el número a buscar" + "\n" + "2- Generar automaticamente (Entre 0-100)");
            M = int.Parse(Console.ReadLine());  //Almaceno el modo de juego

            //Activando el modo de juego 1
            if (M == 1)
            {
                Console.WriteLine("Ingrese el número a buscar");
                N = int.Parse(Console.ReadLine());
            }
            else if (M == 2)  //Activando el modo de juego 2
            {
                Random n = new Random();
                N = n.Next(0, 100);
                Console.WriteLine("Modo aleatorio seleccionado");
            }
            else if (M != 1 || M != 2)
            {
                Console.WriteLine("La opción ingresada no es válida");
                band = false;
            }
            //Buscando el número
            while (N != I && band == true)
            {
                Console.Write("Ingrese un número: ");
                I = int.Parse(Console.ReadLine());
                if (I > N)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (I < N)
                {
                    Console.WriteLine("El número es mayor");
                }
                con++;
            }
          
            //Mostrando en pantalla cuando el número es escontrado
            if(band == true)
            {
                Console.WriteLine("Ha encontrado el número " + N + " en " + con + " intentos ");
            }

            Console.ReadKey();
            
        }
    }
}
