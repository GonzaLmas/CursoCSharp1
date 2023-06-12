using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, con = 0;

            Console.WriteLine("Ingrese nro: ");
            n = int.Parse(Console.ReadLine());

            for(int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                    con++;
            }
            
            if(con == 2)
                Console.WriteLine("El nro es primo");
            else
                Console.WriteLine("El nro NO es primo");

        }
    }
}
