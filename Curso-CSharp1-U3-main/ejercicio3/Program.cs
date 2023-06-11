using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            float importe, importeFinal;

            Console.WriteLine("Ingrese el importe: ");
            importe = float.Parse(Console.ReadLine());

            if(importe < 1000){
                importeFinal = importe;
            }else if(importe >= 1000 && importe < 5000){
                importeFinal = importe * 0.90F;
            }else{
                importeFinal = importe * 0.82F;
            }

            Console.WriteLine("El importe final es: " + importeFinal.ToString("0.00"));
        }
    }
}
