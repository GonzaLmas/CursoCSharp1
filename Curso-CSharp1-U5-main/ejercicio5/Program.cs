using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0, maxP = 0,  minI = 0, p;
            bool bp = true, bi = true;

            while(n < 4)
            {
                Console.WriteLine("Ingrese nro: ");
                p = int.Parse(Console.ReadLine());

                if(p % 2 == 0)
                {
                    if(bp)
                    {
                        maxP = p;
                        bp = false;
                    }                
                     else
                    {
                        if(p > maxP)
                            maxP = p;
                    }
                }
                else
                {
                    if(bi)
                    {
                        minI = p;
                        bi = false;
                    }
                    if(p < minI)
                        minI = p;
                }
                
                n++;
            }

            Console.WriteLine("El máx par es: " + maxP);
            Console.WriteLine("El min impar es: " + minI);
        }
    }
}
