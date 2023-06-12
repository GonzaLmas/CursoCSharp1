using System;

namespace ejrcicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numeros = new int [10];
            int con = 0, acu = 0, prom = 0;
            


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese 10 nros: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                con++;
                acu += numeros[i];
            }

            prom = acu / con;
            Console.WriteLine("El promedio es: " + prom.ToString("0.00"));

            for (int i = 0; i < 10; i++)
            {
                if(numeros[i] > prom)
                {
                    Console.WriteLine("Los nros ingresados mayores al promedio son " + numeros[i]);    
                }
            }

           
        
        }
    }
}
