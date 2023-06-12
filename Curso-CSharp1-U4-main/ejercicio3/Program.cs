using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int procesador, ram, disco, precio = 0, precioFinal = 0;

            Console.WriteLine("Elija una opción de CPU: ");
            procesador = int.Parse(Console.ReadLine());
        

            switch(procesador)
            {
                case 1:
                    Console.WriteLine("Elija la memoria: ");
                    ram = int.Parse(Console.ReadLine());

                    switch(ram)
                    {
                        case 1:
                            precio = 800;
                            break;
                        case 2:
                            precio = 900;
                            break;
                        case 3:
                            precio = 1000;
                            break;
                        default:
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Elija la memoria: ");
                    ram = int.Parse(Console.ReadLine());

                    switch(ram)
                    {
                        case 1:
                            precio = 900;
                            break;
                        case 2:
                            precio = 1000;
                            break;
                        case 3:
                            precio = 1400;
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Elija la memoria: ");
                    ram = int.Parse(Console.ReadLine());

                    switch(ram)
                    {
                        case 1:
                            precio = 1200;
                            break;
                        case 2:
                            precio = 1400;
                            break;
                        case 3:
                            precio = 2000;
                            break;
                        default:
                            break;
                    }
                    break;
            }   
            

            Console.WriteLine("Elija el si quiere disco de 1TB: ");
            disco = int.Parse(Console.ReadLine());

            if(disco == 1)
                precioFinal = precio + 300;
            else 
                precioFinal = precio;

            Console.WriteLine("El precio de la PC es: " + precioFinal);


























        }
    }
}
