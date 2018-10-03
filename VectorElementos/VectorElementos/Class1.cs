using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorElementos
{
    class Class1
    {
        private int[] vector;
        private int[] vectorOrdenado;
        int i,j,aux, cont = 0;

        public void Cargar()
        {
            vector = new int[10];
            Console.WriteLine("Ingrese los datos del vector");
            for(i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese el dato " + (i + 1) + " :");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public void CopiandoV()
        {
            vectorOrdenado = new int[10];
            for(i = 0; i < vector.Length; i++)
            {
                vectorOrdenado[i] = vector[i];
            }
        }
        public void OrdenandoV()
        {
            for (int i = 1; i < vector.Length; i++)
                for (int j = vector.Length - 1; j >= i; j--)
                {
                    if (vectorOrdenado[j - 1] > vectorOrdenado[j])
                    {
                        aux = vectorOrdenado[j - 1];
                        vectorOrdenado[j - 1] = vectorOrdenado[j];
                        vectorOrdenado[j] = j;
                    }
                }
        }

        public void Comparar()
        {
            for(i = 0; i < vector.Length; i++)
            {
                if (vector[i] == vectorOrdenado[i])
                {
                    cont++;
                }
            }
        }

        public void Imprimir()
        {
            if(cont++ == 10)
            {
                Console.WriteLine("EL vector esta ordenado de menor a mayor");
            }
            else
            {
                Console.WriteLine("EL vector no esta ordenado");
            }
        }
    }
}
