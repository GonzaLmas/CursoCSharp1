using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c;

            Console.WriteLine("Ingrese un nro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nro:");
            c = int.Parse(Console.ReadLine());

            if((a + b) > (b * c))   
                Console.WriteLine("La suma de los dos primeros nros es mayor al producto de los dos últimos nros");
            else
                Console.WriteLine("La suma de los dos primeros nros NO es mayor al producto de los dos últimos nros");

        }
    }
}
