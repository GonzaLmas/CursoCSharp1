using System;

namespace cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, con = 0;
            
            Console.WriteLine("Ingrese nro: ");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                con++;
                Console.WriteLine("Ingrese nro: ");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Ingresaste: " + con + "nros");
        }
    }
}
