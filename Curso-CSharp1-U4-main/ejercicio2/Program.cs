using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float importe, litros, precioFinal;

            Console.WriteLine("Ingrese el importe de la venta:");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros:");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500)
                precioFinal = importe * 0.75F;
            else 
                if(litros < 500 && litros > 300)
                    precioFinal = importe * 0.85F;
                else{ 
                    if(litros < 300 && litros > 100)
                        precioFinal = importe * 0.9F;
                    else
                        precioFinal = importe;
                    }

            Console.WriteLine ("El precio final es: " + precioFinal.ToString("0.00"));
        }
    }
}
