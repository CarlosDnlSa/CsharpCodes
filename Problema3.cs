/*Programado por: --Carlos Daniel Ospina Salazar--
 * 
 * Descripcion:   --Dada una cadena de texto ingresado por el usuario desarrollaremos una aplicacion que nos permita modificar
 *                  el String ingresado--
 *                  
 * Entradas:      --cont = 0, camb = 0, UltimaP = 0, PrimeraP = 0, BorrarU, pos--
 * 
 * Salidas:       --Borrar donde se encuentren vocales y numeros, reemplazar la primera posicion borrada por '$', reemplazarla 
 *                  ultima posicion borrada por '?', borrar el ultimo caracter e ingresa el modulo en una posicion ingresada por
 *                  el usuario--
 * 
 * Licencia:      --Creative Commons 3.0--
 *           
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vocales = new char[20] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String texto;
            char borrar = ' ';
            int cont = 0, camb = 0, UltimaP = 0, PrimeraP = 0, BorrarU,pos;


            Console.WriteLine("Ingrese un texto");              //Solicitando el texto
            texto = Console.ReadLine();                         //Leyendo la frase ingresada

            BorrarU = texto.Length - 1;

            char[] myChar = texto.ToCharArray();               //Convirtiendo el texto en una vector 

            for (int i = 0; i < myChar.Length; i++)             //Para i = 0 hasta el largo de el arreglo que es el mismo texto
            {
                for (int j = 0; j < vocales.Length; j++)        //Para j = 0 hasta el largo del el vector que tiene las vocales
                    if (myChar[i] == vocales[j])                //Si el arreglo del texto es igual a alguna de las vocales entonces:
                    {
                        myChar[i] = borrar;                     //Vamos a reemplaza esa posicion por ' '
                        camb = i;                               //Guardamos la posicion donde hizo el primer cambio            
                        UltimaP = i;                            //Guardamos la ultima posicion donde se hizo el cambio
                        if (cont == 0)                          //Si el contador es igual a 0 nos guardara la ubicacion donde cambio la primera vocal
                        {
                            PrimeraP = camb;                    //Guardamos camb el PrimeraP
                            cont++;                             //Aumentamos el contador para que evitar alterar el valor ya ingresado            
                        }

                    }
            }

            //El objetivo de los cambios entre Char y String es para mostrar los cambios progresivamente


            string s = new string(myChar);                      //Cambiamos el vector por un String
            Console.WriteLine(s);                               //Imprimimos el string

            char[] myDato = s.ToCharArray();                    //Convertimos el String a un arreglo
            myDato[PrimeraP] = '$';                             //Reemplazamos la PrimeraP por un '$'
            string m = new string(myDato);                      //Convertimos el vector en un string (Otra vez :( )
            Console.WriteLine(m);                               //Imprimos el String resultante


            char[] myArray = m.ToCharArray();                   //Convertimos el String a un arreglo
            myArray[UltimaP] = '?';                             //Reemplazamos la PrimeraP por un '$'
            string n = new string(myArray);                     //Convertimos el vector en un string (Otra vez :( X 2 )
            Console.WriteLine(n);                               //Imprimos el String resultante

            char[] Vector = n.ToCharArray();                    //Convertimos el String a un arreglo
            Vector[BorrarU] = borrar;                           //BorrarU tiene la ultima posicion y la reemplazamos por ' '
            string o = new string(Vector);                      //Convertimos el vector en un string (Otra vez :( X 3 )
            Console.WriteLine(o);                               //Imprimos el String resultante

            //Insertando el modulo '%'
            char[] VectorFinal = o.ToCharArray();               //Convertimos el String a un arreglo (Es la ultima vez)
            Console.WriteLine("Posición en la que deseas insertar el simbolo %");  //Pedimos la posicion al usuario
            pos = int.Parse(Console.ReadLine());                                    //La leemos, la convertimos en un entero y la almacenamos en pos

            if ( pos  < VectorFinal.Length)                                         //Si pos es vemos al largo de el VectorFinal (Tiene la frase en un vector) entonces
            {
                if (VectorFinal[pos] == ' ')                                        //Si la posicion esta vacia encontes:
                {
                      VectorFinal[pos] = '%';                                       //Ubicamos el modulo es esa posicion
                      string f = new string(VectorFinal);                           //Lo convercimos en un string (Otra vez :( X 4 )
                      Console.WriteLine(f);                                         //Imprimimos el texto resultante    
                }
                else
                {
                    Console.WriteLine("La posición no esta vacia");                 //Si la posicion no es igual a ' ', entonces la posicion no esta vacia
                }
            }
            else
            {
                Console.WriteLine("El número de la posición no es válido");        //Si la posicion es mayor a el largo del texto la posicion no existe, no es valida
            }

          
            Console.ReadKey();
        }
    }
}
