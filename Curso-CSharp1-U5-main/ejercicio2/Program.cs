using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int n, max = 0; // mas la le asignó un valor cero para que el compilador no tire error de que no está asignada
          

            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(x == 0) // acá pregunto si está en la primer vuelta, entonces el nro ingresado sería el max
                {
                    max = n;
                }
                else
                {
                    if(n > max)
                        max = n;
                }

            }
            
            Console.WriteLine("El nro mayor es: " + max);

        }
    }
}
