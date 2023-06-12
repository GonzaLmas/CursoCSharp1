using System;

namespace corteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* En general, casi siempre, el corte de control va a estar formado por un while dentro de orto while. 
            Se usa para manejar lotes de datos agrupados. Este método falla si NO se trabaja de manera agrupada*/

            int legajo, edad, codigoEquipo, equipoActual;
            float sueldo;

            /* códigos de equipo
                1- River
                2- Boca
                3- Racing*/

            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());

            while(sueldo > 0)
            {
                equipoActual == codigoEquipo; // esta asignación es la clave del corte de control. Asigno que el último equipo cargad sea el equipo actual.
                while(codigoEquipo == equipoActual) // con esto se que la persona que voy a ingresar es del mismo equipo.
                {
                    // acá procesamos...

                    Console.WriteLine("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());

                    // acá se puede mostrar resultados
                }
                    // mostrar lo que necesite mostrar
            }
            // acá tambien se puede mostrar resultados
        }
    }
}
            /* Cada equipo va a cortar cuando cambie de equipo. Explicación: cargo un sueldo mayor a 0 (o sea que hay una persona cargada), entonces entra al while 
            grande. El equipo de esa persona (codigoEquipo (2)) pasa a ser el equipo actual ya que lo asigné en la línea 32, entonces entra al while chico. Cargas otra persona. 
            Pregunta si el codigoEquipo es igual al equipoActual (último equipo ingresado), si lo es, sigue en el while chico. si no lo es, sale del while chico y pregunta al 
            while grande si el sueldo > 0 (si porque es otra persona) y carga ese nuevo codigoEquipo a equipoActual. Asi es como te aseguras que tenes a TODAS las personas 
            cargadas agrupadas por equipo. Si es de otro equipo (codigoEquipo (1)), sale del while chico y en la línea 32 carga este codigoEquipo al equipoActual. 
            Entonces entra de nuevo al while chico pero ya está cargando al otro equipo. Al terminar todo, ya te aseguras que tenes a TODAS las personas cargadas agrupadas por equipo.*/