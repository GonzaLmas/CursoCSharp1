using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float totalFacturado;
            float comision = 0.05F; // la "F" es para decirle a la Pc que NO es un número lineal, sino que es un número float
            float sueldoFijo = 15000;
            float sueldoFinal;


            Console.WriteLine("Ingrese el total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());

           sueldoFinal = totalFacturado * comision + sueldoFijo;

            Console.WriteLine("El total a cobrar es: " + sueldoFinal);







        }
    }
}
