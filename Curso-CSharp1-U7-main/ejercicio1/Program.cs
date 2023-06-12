using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numeros = new int [10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese 10 números: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            bool bi = true;
            int max = 0, pos = 0;

            for (int x = 0; x < 10; x++)
            {
                if(bi)
                {
                    max = numeros[x];
                    pos = x + 1;
                    bi = false;        
                }
                else 
                {
                    if(numeros[x] > max)
                    {
                        max = numeros[x];
                        pos = x + 1;
                    }
                }
            }

            Console.WriteLine("El número más grande es: " + max);
            Console.WriteLine("La posición en la que se encuentra es: " + pos);


        }
    }
}
