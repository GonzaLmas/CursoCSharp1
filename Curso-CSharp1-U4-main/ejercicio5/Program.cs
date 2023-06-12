using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingrese nro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nro: ");
            c = int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese nro: ");
            d = int.Parse(Console.ReadLine());
            
            if(a < b){
                if(b < c){
                    if(c < d){
                        Console.WriteLine("Los nros están ordenados");
                    }else {
                        Console.WriteLine("Los nros NO están ordenados");
                    }
                }else 
                    Console.WriteLine("Los nros NO están ordenados");
            }else
                Console.WriteLine("Los nros NO están ordenados");












        }
    }
}
