using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] frase = new char [30]; // creo el vector
            char letraRemp, letraNueva, letra;
            int indice = 0;

            Console.WriteLine("Ingrese letra por letra la frase: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '0' && indice < 30)// voy cargando el vector con el límite de cant de letras
            {
                frase[indice] = letra;
                Console.WriteLine("Ingrese letra por letra la frase: ");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            frase[indice] = '\0'; // determino el final de la cadena
            Console.WriteLine("La frase es: ");
            indice = 0;
            while(frase[indice] != '\0') // lo recorro teniendo en cuneta el final de la cadena
            {
                Console.Write(frase[indice]);
                indice++;
            }

            Console.WriteLine("Ingrese letra a reemplazar: ");
            letraRemp = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            indice = 0;
            while(frase[indice] != '\0')
            {
                if(frase[indice] == letraRemp)
                    frase[indice] = letraNueva;        
                indice++;    
            }

            Console.WriteLine("La frase nueva es: " + frase[indice]);
            indice = 0;
            while(frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
