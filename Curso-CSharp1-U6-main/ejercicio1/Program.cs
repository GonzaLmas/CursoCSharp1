using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
             int n, acu = 0;

            for (int x = 0; x < 10; x++)
            {
                int con = 0;
               
                Console.WriteLine ("Ingrese nro: ");
                n = int.Parse(Console.ReadLine());

                for (int y = 1; y <= n; y++)
                {
                    if(n % y == 0)
                        con++;
                }

                if(con == 2)
                    acu++;
            }

            Console.WriteLine("La cantidad de nros primos es: " + acu);
        }
    }
}
