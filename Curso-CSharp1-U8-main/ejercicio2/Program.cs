using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, con = 0, resultado;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n1 = int.Parse(Console.ReadLine());

                resultado = par(n1);
                
                if (resultado == 1)
                    con++;
            }

            Console.WriteLine("La cantidad de nros pares es: " + con);
        }

        static int par(int a)
        {
            if (a % 2 == 0)
                return 1;
            else
                return 0;  
        }
    }
}
