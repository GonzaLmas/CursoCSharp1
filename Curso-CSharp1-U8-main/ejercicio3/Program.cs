using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu = 0, con = 0;
            float promedio;

            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());
            
            while (n != 0)
            {   
                if (primo(n))
                {
                    con++;
                    acu += n;
                }
                
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

            }
            promedio = acu / con;   
            Console.WriteLine("El promedio de los nros primos es: " + promedio.ToString("0.00"));
        }
 
        static bool primo(int a)
        {
            int con = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    con++;
            }

            if (con == 2)
                return true;
            else
                return false;
        }
    }
}
