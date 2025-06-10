using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // File.ReadAllLines(@"fichier.txt") lit toutes les lignes du fichier et les retourne dans un tableau de chaînes de caractères.
            // File.WriteAllText(@"fichier.txt", "Bonjour, je suis un fichier texte") écrit une chaîne de caractères dans un fichier.
            // File.WriteAllLines(@"fichier.txt", lignes) écrit un tableau de chaînes de caractères dans un fichier.
            // File.ReadAllText(@"fichier.txt") lit tout le contenu du fichier et le retourne dans une chaîne de caractères.

          String[] lignes = File.ReadAllLines(@"fichier.txt");
          foreach (String ligne in lignes)
          {
            Console.WriteLine(ligne);
          }

          String message = "Bonjour, je suis un fichier texte";

          File.WriteAllText(@"fichier.txt", message);

          Console.WriteLine(message);

          

            Console.ReadKey();
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
