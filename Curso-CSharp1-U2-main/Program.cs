using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;

            Console.WriteLine("Escriba un número: ");
            n1 = int.Parse(Console.ReadLine());

            resultado = n1 * n1 * n1;

            Console.WriteLine("El cubo del número ingresado es: " + resultado);

        }
    }
}
