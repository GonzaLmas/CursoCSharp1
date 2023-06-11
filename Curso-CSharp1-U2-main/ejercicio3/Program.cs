using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, velocidad, tiempo;
            
            Console.WriteLine("Ingrese la distancia (en Km) que hay entre BsAs y Mar del Plata: ");
            km = int.Parse(Console.ReadLine()); //acá hay un error, al tener datos tipo "float", la instrucción sería "float.Parse"

            Console.WriteLine("Ingrese la velocidad promedio (en Km/h) con la que viajaban: ");
            velocidad = int.Parse(Console.ReadLine()); //acá hay un error, al tener datos tipo "float", la instrucción sería "float.Parse"

            tiempo = km / velocidad;

            Console.WriteLine("El tiempo que tardan en llegar es: " + tiempo.ToString("0.00")); /*el "tostring" sirve apra transformar en txt.
             los "0.00" que están dentro de los paréntesis, es un argumento, y es el formato en como quiero que me muestre el resultado. 
             Sirve para números decimales, en este caso solo dos números después de la coma

               para que el tiempo muestre un tipo de dato "float", TODOS los datos tienen que ser tipo "float". 
               Si tengo los km y la velocidad en dato tipo "int", por mas que tenga el tiempo en tipo "float", 
               NO va a mostrar el tiempo con un número con coma.*/





        }
    }
}
