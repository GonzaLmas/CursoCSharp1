using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad;
            int montoAPagar;

            Console.WriteLine("Ingrese el precio del artículo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            montoAPagar = producto(precio,cantidad);

            Console.WriteLine("El monto total a pagar es: " + montoAPagar);
        }

        static int producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
