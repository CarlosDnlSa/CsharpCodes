/*
    Programado por: Carlos Daniel Ospina Salazar

    Descripcion: Este programa toma como entrada una frase y devuelve las posiciones donde aparecen los caracteres '?' y '&',
                 regresa ademàs un vector con cambio de caracteres en posiciones indicadas (Cambiar simbolos por letras y 
                 vocales mayusculas con minusculas).
    Entradas: Frase "CL4S3?L6N3S&3STR6R4?D3&D4T0S", char[] vocales (Vocales en minuscula) y char[] vocalesMay (Vocales en mayuscula).
    
    Salidas: 5 , 11 , 19 , 22 ,  
            CLASE LUNES ESTRUCTURA DE DATOS
            CLaSe LuNeS eSTRuCTuRa De DaToS

    Licencia: Creative Commons 3.0

 */

using System;
 
namespace Problema2
{
    class Problema2
    {
        public static void Main (string[] args)
        {
            //Datos del programa
            String Frase = "CL4S3?L6N3S&3STR6R4?D3&D4T0S";
            char[] vocales = new char[5] {'a','e','i','o','u'};
            char[] VocalesMay = new char[5] {'A','E','I','O','U'};

            //Convirtiendo la frase en un arreglo de caracteres que se almaceneran en el vector arreglo
            char[] array = Frase.ToCharArray();


            //Ciclo for que va hasta el total de los indices en el array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '?' || array [i] == '&'){   //Comparando si el indice i es igual a '?' o igual a '&'
                    array[i] = ' ';                         //Remplaza los caracteres '?' y '&' por espacios en la frase pedida
                    Console.Write( i + " , ");              //Me muestra el indice i donde encontro los caracteres, la coma me separa los datos
                   
                }

                else if (array[i] == '4'){                 //Y si el valor del indice tiene un 4 lo debe remplazar
                     array[i] = 'A';                       //Aca lo estoy remplazando por una 'A'
                }
                   
                else if (array[i] == '3'){                 //Y si el valor del indice tiene un '3' lo debe remplazar
                     array[i] = 'E';                       //Aca lo estoy remplazando por una 'E'
                }

                else if (array[i] == '6'){                 //Y si el valor del indice tiene un '6' lo debe remplazar
                     array[i] = 'U';                       //Aca lo estoy remplazando por una 'U'
                } 

                 else if (array[i] == '0'){               //Y si el valor del indice tiene un '0' lo debe remplazar 
                     array[i] = 'O';                      //Aca lo estoy remplazando por una 'O'
                } 
                else{

                }       
            }

            String s = new string (array);              //Este metodo me convierte el array en un String de nuevo
            s = s.Insert(17, "CTU");                    //Aca estoy insertando CTU que le falta a la frase para formar la palabra "ESTRUCTURA"
            Console.WriteLine(s);                       //Imprimo s que tiene el array convertido en String

            char[] vector = s.ToCharArray();            //Vuelvo a transformar la frase en un vector para cambiar las vocales a minusculas
            

            //Comenzando otro ciclo for que va hasta el largo del vector
            for (int j = 0; j < vector.Length; j++){   

                if (vector[j] == VocalesMay[0])          //Analiza si el indice del vector coincide con el indice 0 del vector VocalesMay (Este contiene las vocales mayusculas)     
                    vector[j] = vocales[0];              //Si es asi la remplaza con el valor que tiene vocales[0] (Contiene las vocales en minuscula)

                else if (vector[j] == VocalesMay[1]){   //Analiza si el indice del vector coincide con el indice 1 del vector VocalesMay (Este contiene las vocales mayusculas)
                     vector[j] = vocales[1];            //Si es asi la remplaza con el valor que tiene vocales[1] (Contiene las vocales en minuscula)         
                }
                else if (vector[j] == VocalesMay[2]){    //Analiza si el indice del vector coincide con el indice 2 del vector VocalesMay (Este contiene las vocales mayusculas)    
                     vector[j] = vocales[2];             //Si es asi la remplaza con el valor que tiene vocales[2] (Contiene las vocales en minuscula)  
                }
                else if (vector[j] == VocalesMay[3]){   //Analiza si el indice del vector coincide con el indice 3 del vector VocalesMay (Este contiene las vocales mayusculas)
                     vector[j] = vocales[3];            //Si es asi la remplaza con el valor que tiene vocales[3] (Contiene las vocales en minuscula)   
                }
                else if (vector[j] == VocalesMay[4]){   //Analiza si el indice del vector coincide con el indice 4 del vector VocalesMay (Este contiene las vocales mayusculas)
                     vector[j] = vocales[4];            //Si es asi la remplaza con el valor que tiene vocales[4] (Contiene las vocales en minuscula)  
                }
            }
            String v = new string (vector);             //Me vuelve a transformar el vector en un string 
            Console.WriteLine(v);                       //Me muestra v que contiene el vector convertido en String 
            Console.ReadKey();
        }
    }
}
