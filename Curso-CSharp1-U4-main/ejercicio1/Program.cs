using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a, b, resultado;

            Console.WriteLine("Ingrese un nro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            b = int.Parse(Console.ReadLine());
        
            if(a > b)
                resultado = a - b;
            else if(a == b)
                resultado = a + b;
            else
                resultado = a * b;
            
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
