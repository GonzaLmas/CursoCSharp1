using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float suma = 0, con = 0, n = 0, prom;
            int e = 0;

            while(n < 20)
            {
                Console.WriteLine("Ingrese edad: ");
                e = int.Parse(Console.ReadLine());
                if(e > 18)
                {
                    suma += e;
                    con++;
                }
                n++;
             }

            prom = suma / con;

            Console.WriteLine("El prom de los mayores a 18 es: " + e.ToString("0.00"));

        }
    }
}
