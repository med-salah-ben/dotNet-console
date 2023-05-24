using System;

namespace TriangleSurfaceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangle, hauteurTriangle;
            Console.WriteLine("Calcul de la surface d'un triangle");
            Console.WriteLine("----------------------------------");
            Console.Write("Entrez la base du triangle : ");
            if (!double.TryParse(Console.ReadLine(), out baseTriangle))
            {
                Console.WriteLine("La valeur de la base n'est pas valide.");
                return;
            }
            Console.Write("Entrez la hauteur du triangle : ");
            if (!double.TryParse(Console.ReadLine(), out hauteurTriangle))
            {
                Console.WriteLine("La valeur de la hauteur n'est pas valide.");
                return;
            }

            double surface = getSurFace(baseTriangle, hauteurTriangle);
            Console.WriteLine($"La surface du triangle est : {surface}");

            Console.ReadLine();
        }

        static double getSurFace(double baseTriangle, double hauteurTriangle)
        {
            return (baseTriangle * hauteurTriangle) / 2;
        }
    }
}
