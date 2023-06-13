using System;

namespace ejercicio2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, con = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n1 = int.Parse(Console.ReadLine());
                
                if (par(n1))
                    con++;
            }

            Console.WriteLine("La cantidad de nros pares es: " + con);
        }

        static bool par(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;  
        }
    }
}
