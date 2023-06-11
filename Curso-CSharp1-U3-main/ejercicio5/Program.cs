using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b, c, d, cont = 0;

            Console.WriteLine("Ingrese un nro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último nro: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if(a > 100){
                Console.WriteLine(a);
                cont++;
            }
            if(b > 100){
                Console.WriteLine(b);
                cont++;
            }
            if(c > 100){
                Console.WriteLine(c);
                cont++;
            }
            if(d > 100){
                Console.WriteLine(d);
                cont++;            
            }

            if(cont == 0)
                Console.WriteLine("\n No hay nros mayores a 100");
        }
    }
}
