using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a, b, c, d, menor;

            Console.WriteLine("Ingrese un nro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último nro: ");
            d = int.Parse(Console.ReadLine());
            
            if(a < b)
                menor = a;
            else
                menor = b;
            if(c < menor)
                menor = c;
            if(d < menor)
                menor = d;

            Console.WriteLine("El nro menor es: " + menor);
        }
    }
}
