using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eleves = { "Alice", "Bob", "Charlie", "Diane", "Eve" };
            int[] notes = { 12, 8, 17, 15, 9 };

            AfficherEleves(eleves);
            AfficherNotes(notes, eleves);
            double moyenne = CalculerMoyenne(notes);
            AfficherMeilleursEleves(notes, eleves);

            Console.WriteLine("Entrez le prénom de l'élève à chercher :");
            string prenom = Console.ReadLine();
            ChercherEleve(prenom, eleves);

            Console.ReadKey();
        }

        static void AfficherEleves(string[] eleves)
        {
            foreach (string prenom in eleves)
            {
                Console.WriteLine(prenom);
            }
        }

        static void AfficherNotes(int[] notes, string[] eleves)
        {
            for (int i = 0; i < eleves.Length; i++)
            {
                Console.WriteLine(eleves[i] + " a eu " + notes[i] + " de moyenne");
            }
        }

        static double CalculerMoyenne(int[] notes)
        {
            int somme = 0;
            foreach (int note in notes)
            {
                somme += note;
            }
            double moyenne = (double)somme / notes.Length;
            Console.WriteLine("La moyenne de la classe est de " + moyenne);
            return moyenne;
        }

        static void AfficherMeilleursEleves(int[] notes, string[] eleves)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] >= 15)
                {
                    Console.WriteLine(eleves[i] + " est un excellent élève avec " + notes[i] + " de moyenne");
                }
            }
        }

        static bool ChercherEleve(string prenom, string[] eleves)
        {
            bool trouve = false;
            foreach (string eleve in eleves)
            {
                if (eleve == prenom)
                {
                    trouve = true;
                    Console.WriteLine(eleve + " est un(e) élève de la classe");
                    break;
                }
            }
            if (!trouve)
            {
                Console.WriteLine(prenom + " n'est pas un(e) élève de la classe");
            }
            return trouve;
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme