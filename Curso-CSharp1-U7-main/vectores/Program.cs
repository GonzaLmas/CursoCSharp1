using System;

namespace vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int [] numeros = new int [10];

            // como escribir un vector
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());

                numeros[x] = n;
            }

            int acu = 0;
            
            // como leer un vector
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
                Console.WriteLine("Los valores son: " + numeros[x]);
            }
            
            int prom = acu / 10;



        }
    }
}
