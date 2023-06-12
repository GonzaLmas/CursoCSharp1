using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, con, numGrupo = 0;

            do
            {
                numGrupo++;
                con = 0;
                
                Console.WriteLine("Ingrese nros. Indique el fin de la lista ingresadno un cero");
                n = int.Parse(Console.ReadLine());

                while (n > 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad del grupo " + numGrupo + " es: " + con);

            }while(n >= 0);
        }
    }
}
