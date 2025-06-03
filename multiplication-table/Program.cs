using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Entrez le nombre d'une  table compris entre 1 et 10 :");
          int n = int.Parse(Console.ReadLine());
          
          while (n < 1 || n > 10) {
            Console.WriteLine("Nombre invalide. Veuillez entrer un nombre entre 1 et 10.");
            n = int.Parse(Console.ReadLine());
          }

          for (int i = 0; i <= 10; i++) {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
          }

          Console.WriteLine("Appuyez sur une touche pour quitter...");

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme