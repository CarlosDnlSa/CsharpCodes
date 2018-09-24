using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];
            int[] copNum = new int[20];
            String num1;
            float media,Sum,posA, posB,mediana;
            int dato, cont = 20, con = 0, x = 0,j = 0, aux,sumarDatos = 0, busS;

            while (con < 20)
            {
               Console.WriteLine("Faltan por ingresar " + cont + " valores");
               Console.WriteLine("Ingrese el numero: ");
               dato = int.Parse(Console.ReadLine());
               if (dato >= 0 && dato <= 100)
                {
                    num[con] = dato;
                    con++;
                    cont--;
                }
               else
                {
                    Console.WriteLine("El dato no esta dentro del rango");
                }

               //Copiando el vector
               for(x = 0; x < num.Length; x++)
                {
                    copNum[x] = num[x];
                }

               //Seleccion directa

            }

            for (x = 0; x < copNum.Length; x++)
            {
                for (j = x + 1; j < copNum.Length; j++)
                {
                    if (copNum[j] < copNum[x])
                    {
                        aux = copNum[j];
                        copNum[j] = copNum[x];
                        copNum[x] = aux;
                    }
                }
            }

            Console.WriteLine("Menor a mayor -- Selección directa");
            //Imprimiendo en vector
            for (x = 0; x < num.Length; x++)
            {
                Console.Write(copNum[x] + " ");
            }
           

            

            //Obteniendo la mediana
            posA = copNum[9];
            posB = copNum[10];
            mediana = (posA + posB) / 2;
            Console.WriteLine(" ");
            Console.WriteLine("La mediana es: "+  mediana);

            for (x = 0; x < copNum.Length; x++)
            {
                sumarDatos = sumarDatos + copNum[x];
            }

            Sum = sumarDatos;
            media = Sum / 20;
            Console.WriteLine("La media es: " + media);
            //Busqueda secuencial
            Console.WriteLine("Ingrese el valor a buscar");
            busS = int.Parse(Console.ReadLine());

            for (x = 0; x < copNum.Length; x++)
            {
                if (copNum[x] == busS)
                {
                    Console.Write(x + " ");
                }
            }
            Console.ReadKey();

        }
    }
}
