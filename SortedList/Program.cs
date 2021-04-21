using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList
{
    using System;
    using System.Collections;
    public class SamplesSortedList
    {

        public static void Main()
        {

            //  Se crea e inicia un nuevo SortedList
            SortedList ListaAutos = new SortedList();
            ListaAutos.Add(9, "Toyota");
            ListaAutos.Add(4, "Volvo");
            ListaAutos.Add(6, "Ferrari");
            ListaAutos.Add(1, "Fiat Siena");
            ListaAutos.Add(8, "Megane");
            ListaAutos.Add(3, "Peugeot 207");
            ListaAutos.Add(2, "Peugeot 2008");
            ListaAutos.Add(5, "McLaren");

            // Muestra la propiedades y valores de SortedList
            Console.WriteLine("Lista de Autos Disponibles");
            Console.WriteLine("  Count:    {0}", ListaAutos.Count); //Count es un tipo de valor entero que devuelve la cantidad de elementos que tenemos actualmente en la lista
            Console.WriteLine("  Capacity: {0}", ListaAutos.Capacity); //Numero maximo de elementos que se pueden insertar en la lista
            Console.WriteLine("  Keys and Values:"); //Devuelve una cadena con las KEYS y VALUES de los elementos
            PrintKeysAndValues(ListaAutos); //Imprime por consola la lista de autos con sus llaves y valores
        }


        /*
         * Ciclo for utilizado para acumular los elementos y luego agregarlos a la lista de manera incremental
         */
        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < myList.Count; i++) 
            {
                Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
            Console.WriteLine();
        }
    }

    /*
Este codigo produce las siguientes salidas

ListaAutos
  Count:    3
  Capacity: 16
  Keys and Values:
    -KEY-    -VALUE-
    1:    "Toyota"
    2:    "Volvo"
    3:    "Ferrari"
*/
}
