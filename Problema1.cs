/*
 Programado por: Carlos Daniel Ospina Salazar

 Descripcion del programa: --Este programa recibe como entrada una frase establecida de 30 caracteres (ni mas ni menos),
                             que es ingresada por el usuario y luego es comparada con una frase preestablecida.--
                             
 Variables: texto=         -- Guarda el texto ingresado por el usuario, PrimeraPa= Guarda la primera palabra si es vocal, 
                              espacio = nos ayudara a comparar y establecer donde hay espacion, comp = nos ayudara a ver si
                              la frase ingresada es igual a la preestablecida, compV = nos ayudara a saber si la palabra empieza
                              por vocal, compA = nos ayudara a establecer si una palabra tiene tilde en las dos ultimas posiciones.--

Entrada:                   --Texto de 30 caracteres--

Salida:                    --Numero de vocales, numero de espacios, numero de consonantes, la primera palabra si es vocal,
                             la ultima palabra si es aguda, si la frase ingresada por el usuario es la misma que la predefinida.

Licencia                   --Creative Commons 3.0--

                   
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto, PrimeraPa = " ", UltimaP = " ";
            char espacio = ' ';
            bool comp = false, compV = false, compA = false;
            int con = 0, conE = 0, i, j, cons, x = 0, UltEspacio = 0;
            String frase = "Que bonito suenan las campanas";
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U','á', 'é', 'é', 'é', 'é', 'Á', 'É', 'Í', 'Ó', 'Ú' };
            char[] Agudas = new char[] { 'á', 'é', 'é', 'é', 'é', 'Á', 'É', 'Í', 'Ó', 'Ú' };



            do
            {
                Console.WriteLine("Ingrese un texto (30 caracteres)");  //Pidiendo un texto al usuario
                texto = Console.ReadLine();
            } while (texto.Length != 30);                               //El ciclo Do nos ayudara a comprobar que la frase tenga 30 caracteres



            //Comprobando si la frase ingresada es igual a la predefinida
            if (texto == frase)                                        //Comparando si el texto es igual a la frase
            {
                comp = true;                                           //Convirtiendo el boolean false a true (nos ayudara mas adelante)
            }

            for (i = 0; i < texto.Length; i++)                         //i = 0 hasta el largo del texto
            {
                if (texto[i] == espacio)                               // Si texto en el indice i es igual a espacio ' ', (nos aumentara el contador)
                {
                    conE++;                                            //Aumentando el contador         
                    UltEspacio = i;                                    //UltEspacio nos almacenara el ultimo espacio (servira al momento de mostrar la palabra aguda)
                }
                for (j = 0; j < vocales.Length; j++)                   //Comparando las posiciones del texto con cada una de las vocales
                {
                    if (texto[i] == vocales[j])                        //Si una vocal del texto es igual a una vocal del vector, nos aumentara el contador
                    {
                        con++;                                         //Aumentando el contador     
                    }
                }
            }



            //Comprobando si la primera palabra ingresada es vocal
            while (texto[x] != espacio)                                //Mientras el texto es diferente a espacio ' ' 
            {
                if (texto[0] == vocales[x])                            //Si texto en la primera posicion es igual a cualquiere de las vocales   
                    compV = true;                                      //compV sera verdadero (Sera utilizado mas adelante) 
                x++;                                                   //Este contador nos va a recorrer el vector             
            }

            x = 0;                                                     //Reasignando x a o para que no quede cargado con el valor anterior
            if (compV == true)                                        //Si comV es verdadero significa que la primera palabra es una vocal 
            {
                while (texto[x] != espacio)                           //Mientras que el texto x sea diferente a espacio ' ' (cuando llegue a un espacio se detendra)
                {
                    PrimeraPa = PrimeraPa + texto[x];                //PrimeraPa guardara la palabra obtenida de sumar PrimeraPa con el caracter en la posicion x del texto
                    x++;                                             //El contador aumenta y nos ayuda a recorrer el texto   
                }
            }


            //Encontrando las consonantes
            cons = (texto.Length - con - conE);                     //El numero de consonantes sera el resultado de la resta entre el largo del texto, vocales y espacio


            Console.WriteLine("La frase ingresada tiene " + con + " vocales");          //Imprimiendo con que tiene el numero de vocales
            Console.WriteLine("La frase ingresada tiene " + conE + " espacios");        //Imprimiendo conE que tiene el numero de espacio
            Console.WriteLine("La frase ingresada tiene " + cons + " consonantes");     //Imprimiendo cons que tiene el numero de constantes
            if (compV == true)                                                          //Si compV es verdadero significa que la primera palabra es vocal
            {
                Console.WriteLine("La primera vocal es " + PrimeraPa);                  //Es nos mostrara el valor contenido en PrimerPa
            }



            //Encontrando las palabras agudas
            for (i = 0; i < Agudas.Length; i++)                             //El ciclo for va hasta el largo de el vector palabras agudas
            {
                if (texto[28] == Agudas[i] || texto[29] == Agudas[i])       //Si en las dos ultimas posiciones encuentra una tilde, sera una palabra aguda
                {
                    compA = true;                                           //CompA sera verdadero (es una palabra aguda)
                }
            }
            if (compA == true)                                              //Si la palabra anterior es aguda entonces
            {
                for (i = 1; i <= (29 - UltEspacio); i++)                    //i inicia en 1 hasta 29 - La ultima posicion donde hay un espacio (esa diferencia sera la recorrida)
                {
                    Console.Write(texto[UltEspacio + i]);                   //Nos mostrara la caracteres sin salto de linea para formar una palabra (Empieza con UltEspacio hasta 29)
                }
            }
                 

            if (comp == true)                                               //Esta condicion nos dira si la frase ingresada es igual a la frase preestablecida
            {
                Console.WriteLine("La frase ingresada es igual a la frase predefinida");  //Si es igual nos mostrara este texto
            }
            Console.ReadKey();
        }
    }
}
