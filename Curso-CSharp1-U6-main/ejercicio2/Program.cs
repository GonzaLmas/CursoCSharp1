using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
             - El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
             - Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

            int n, conNum, conImp, grupoImpMax = 0, min, conOrdenados = 0;
            double porcentajeImp, porcentajeMax = 0;
            bool bOrdenados;

            for (int x = 0; x < 5; x++)
            {
                conNum = 0;
                conImp = 0;
                bOrdenados = true;
                n = int.Parse(Console.ReadLine());
                min = n;

                while(n != 0)
                {
                    conNum++;
                    if(n % 2 == 0)
                        conImp++;

                    // punto B
                    if(n <= min)    
                        min = n;
                    else       
                        bOrdenados = false;
                    
                    n = int.Parse(Console.ReadLine());
                }

                porcentajeImp = (conImp * 100) / conNum;

                if(porcentajeImp > porcentajeMax)
                {
                    porcentajeMax = porcentajeImp;
                    grupoImpMax = x + 1;
                }   
                    
                // punto B
                if(bOrdenados)
                    conOrdenados++;
            }       

            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImpMax);
            Console.WriteLine("La cantidad de grupos con nros ordenados es: " + conOrdenados);
        }
    }
}
