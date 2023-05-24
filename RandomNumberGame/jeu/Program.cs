using System;

namespace NombreMystereGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nombreMystere = random.Next(0, 101);
            int nombreEssai = 0;
            bool close = false;

            Console.WriteLine("Bienvenue dans le jeu du Trié!");
            Console.WriteLine("--------------------------------");

            while (!close)
            {
                Console.Write("Entrez un nombre entre 0 et 100 : ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int nombre))
                {
                    Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
                    continue;
                }

                if (nombre < 0 || nombre > 100)
                {
                    Console.WriteLine("Erreur : Le nombre doit être entre 0 et 100.");
                    continue;
                }

                nombreEssai++;

                if (nombre == nombreMystere)
                {
                    Console.WriteLine($"Great, you get correct number in {nombreEssai} tentative !");
                    close = true;
                }
                else if (nombre < nombreMystere)
                {
                    Console.WriteLine("Le nombre plus grand.");
                }
                else
                {
                    Console.WriteLine("Le nombre plus petit.");
                }
            }

            Console.WriteLine("Great !");
            Console.ReadLine();
        }
    }
}
