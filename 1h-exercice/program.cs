using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu du nombre magique !");
            Console.WriteLine("Quel est ton prénom ?");
            string name = Console.ReadLine();

            Random random = new Random();
            int nombreMagique = random.Next(1, 100);
            const int MAX_ATTEMPTS = 5;

            Console.WriteLine("Enchanté " + name + " ! Le nombre magique est compris entre 1 et 100, et tu as " + MAX_ATTEMPTS + " essais.");

            int essaie;
            int tentative = 0;
            bool gagne = false;

            while (tentative < MAX_ATTEMPTS)
            {
                Console.WriteLine("Entre ton nombre :");
                essaie = Convert.ToInt32(Console.ReadLine());
                tentative++;

                if (essaie == nombreMagique)
                {
                    Console.WriteLine("Bravo, tu as trouvé le nombre magique en " + tentative + " tentative(s) !");
                    gagne = true;
                    break;
                }
                else if (essaie < nombreMagique)
                {
                    Console.WriteLine("Trop bas ! Tu es à " + Math.Abs(nombreMagique - essaie) + " près du nombre magique");
                }
                else
                {
                    Console.WriteLine("Trop haut ! Tu es à " + Math.Abs(nombreMagique - essaie) + " près du nombre magique");
                }
            }

            // Affichage du message final
            if (gagne)
            {
                if (tentative == 1)
                {
                    Console.WriteLine("Incroyable, t’es un devin !");
                }
                else if (tentative == 2 || tentative == 3)
                {
                    Console.WriteLine("Pas mal du tout !");
                }
                else if (tentative == 4 || tentative == 5)
                {
                    Console.WriteLine("Bien joué, mais tu peux mieux faire !");
                }
            }
            else
            {
                Console.WriteLine("Tu as perdu ! Le nombre magique était " + nombreMagique);
                Console.WriteLine("Courage, la prochaine fois sera la bonne !");
            }

            Console.ReadKey();
        }
    }
}
