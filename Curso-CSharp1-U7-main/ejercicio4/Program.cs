using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nroArticulo, cantidad;
            int [] articulos = new int [14];

            for (int i = 0; i < 14; i++) // lo que hace es dar 15 vueltas e inicializa en 0 todos los acumuladores: Ese for es para acumular en las 15 posiciones
            {
                articulos[i] = 0;
            }
            
            Console.WriteLine("Ingrese nro de artículo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de artículos vendidos: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                articulos[nroArticulo - 1] += cantidad; // acá lo que hace es cuando la persona cargue en el artículo 3, lo va a cargar en el índice 2
               
                Console.WriteLine("Ingrese nro de artículo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de artículos vendidos: ");
                cantidad = int.Parse(Console.ReadLine());

            }

            // punto a
            int maxCatidad = articulos[0];
            int nroMax = 1;

            for (int i = 0; i < 14; i++)
            {
                if (articulos[i] > maxCatidad)
                {
                    maxCatidad = articulos[i];
                    nroArticulo= i + 1;
                }
            }
            Console.WriteLine("El producto más vendido es el: " + nroArticulo + " con la cantidad de: " + cantidad);

            //punto b
            for (int i = 0; i < 14; i++)
            {
                if (articulos[i] == 0)
                    Console.WriteLine("El producto " + (i + 1) + " no tuvo ventas");           
            }

            //punto c
            Console.WriteLine("La cantidad vendida del artículo 10 es: " + articulos[9]); 
        }
    }

}
