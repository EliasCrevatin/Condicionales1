using System;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            float NotaPrimerExamen, NotaSegundoExamen, NotaTercerExamen;
            float Promedio;


            Console.WriteLine("Cuanto te sacaste en el primer examen?");
            NotaPrimerExamen = float.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto te sacaste en el segundo?");
            NotaSegundoExamen = float.Parse(Console.ReadLine());

            Console.WriteLine("y en el tercer examen?");
            NotaTercerExamen = float.Parse(Console.ReadLine());

            Promedio = (NotaPrimerExamen + NotaSegundoExamen + NotaTercerExamen) / 3; 

            Console.WriteLine("Su promedio es de: " + Promedio.ToString("0.00"));
        }
    }
}
