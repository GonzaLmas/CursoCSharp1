using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // el IF

            int edad = 32;

            if(edad > 21){
                if(edad > 30)
                    Console.WriteLine("30% de descuento");
                else
                    Console.WriteLine("21% de descuento");                
            }else 
                Console.WriteLine("10% de descuento");

       }
    }
}
