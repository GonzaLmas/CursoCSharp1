using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un nro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nro: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = sumar(n1, n2); //acá guardo en resultado lo que resolvió la función "sumar"
       
            Console.WriteLine("El resultado es: " + resultado);       
        }
        //función que dentro de ella suma y retorna a "r" que es el resultado 
        static int sumar(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }
    }
}
