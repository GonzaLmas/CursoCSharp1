using System;

namespace cicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            do
            {
                Console.WriteLine("Ingrese nro: ");
                n = int.Parse(Console.ReadLine());
            }while(n != 0);
        }
    }
}
