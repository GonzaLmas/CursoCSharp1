using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int n;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            if(n > 10)
                Console.WriteLine("El número ingresado es mayor a 10");
            else
                Console.WriteLine("El número ingresado es menor a 10");
        }
    }
}
