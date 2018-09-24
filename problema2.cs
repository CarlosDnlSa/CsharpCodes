/*
 *Programado por: --Carlos Daniel Ospina Salazar--
 * 
 * Descripcion:   --Este programa realiza cambios en una frase preestablecida y muestra los resultados de uno en uno--
 * 
 * Entradas:      --frase =  Esta es la frase que vamos a modificar, vocales[] = Contiene las vocales en minuscula, VocalesMay = Tiene las vocales en mayuscula
 * 
 * Salidas:       --Posiciones donde se encuentran los simbolor '?' y '&', frase reemplazada = "CLASE LUNES ESTRUCTURA DE DATOS"
 *                  vocales mayuscular reemplazadas por minusculas--
 *      
 *Licencia:        --Creative Commons 3.0--
 *  
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "CL4S3?L6N3S&3STR6CT6R4?D3&D4T0S";
            char[] vocales = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            char[] VocalesMay = new char[5] { 'A', 'E', 'I', 'O', 'U' };
            int i = 0;


            char[] array = frase.ToCharArray();                 //Convirtiendo la frase en un arreglo para facilitar las modificaciones

            for (i = 0; i < frase.Length; i++)                  // El ciclo for recorrera la frase
            {
                if (frase[i] == '?' || frase[i] == '&')         //El condicional nos buscara los caracteres '?' y '&' en la frase
                {
                    Console.WriteLine(i);                       //Si se cumple la condicion nos muestra la posicion donde la encontro
                    array[i] = ' ';                             //Reemplaza los caracteres por espacios para formar la frase "CLASE LUNES ESTRUCTURA DE DATOS"
                }
                else if (frase[i] == '4')                       //Y si la frase en la posicion i es igual a '4' la va a reemplazar
                {
                    array[i] = 'A';                             //Reemplazando '4' por 'A'
                }
                else if (frase[i] == '3')                       //Y si la frase en la posicion y es igual a '3'
                {
                    array[i] = 'E';                             //Reemplazando '3' por 'E'
                }

                else if (frase[i] == '6')                       //Y si la frase en la posicion i es igual a '6'
                {
                    array[i] = 'U';                             //Reemplazando '6' por 'U'
                }
                else if (frase[i] == '0')                       //Y si la frase es igual a '0'
                {
                    array[i] = 'O';                             //Reemplazando '0' por una 'O'
                }
            }

            String s = new string(array);                       //Convirtiendo el array en un string de nuevo
            Console.WriteLine(s);                               //Imprimiendo el Array convertido en String

            char[] vector = s.ToCharArray();                    //Lo convertimos de nuevo para cambiar las vocales mayuscular por minusculas

            for (int j = 0; j < vector.Length; j++)
            {

                if (vector[j] == VocalesMay[0])          //Analiza si el indice del vector coincide con el indice 0 del vector VocalesMay (Este contiene las vocales mayusculas)     
                    vector[j] = vocales[0];              //Si es asi la remplaza con el valor que tiene vocales[0] (Contiene las vocales en minuscula)

                else if (vector[j] == VocalesMay[1])
                {                                      //Analiza si el indice del vector coincide con el indice 1 del vector VocalesMay (Este contiene las vocales mayusculas)
                    vector[j] = vocales[1];            //Si es asi la remplaza con el valor que tiene vocales[1] (Contiene las vocales en minuscula)         
                }
                else if (vector[j] == VocalesMay[2])
                {                                       //Analiza si el indice del vector coincide con el indice 2 del vector VocalesMay (Este contiene las vocales mayusculas)    
                    vector[j] = vocales[2];             //Si es asi la remplaza con el valor que tiene vocales[2] (Contiene las vocales en minuscula)  
                }
                else if (vector[j] == VocalesMay[3])
                {                                       //Analiza si el indice del vector coincide con el indice 3 del vector VocalesMay (Este contiene las vocales mayusculas)
                    vector[j] = vocales[3];            //Si es asi la remplaza con el valor que tiene vocales[3] (Contiene las vocales en minuscula)   
                }
                else if (vector[j] == VocalesMay[4])
                {                                       //Analiza si el indice del vector coincide con el indice 4 del vector VocalesMay (Este contiene las vocales mayusculas)
                    vector[j] = vocales[4];            //Si es asi la remplaza con el valor que tiene vocales[4] (Contiene las vocales en minuscula)  
                }
            }

            String v = new string(vector);             //Me vuelve a transformar el vector en un string 
            Console.WriteLine(v);                      //Me muestra el vector transformado en String 
            Console.ReadKey();
        }
    }
}
