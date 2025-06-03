using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Entrez le nombre de nombres à générer (min 2, max 10) :");

          int n = int.Parse(Console.ReadLine());

          while (n < 2 || n > 10) {
            Console.WriteLine("Nombre invalide. Veuillez entrer un nombre entre 2 et 10.");
            n = int.Parse(Console.ReadLine());
          }

          int sum = 0;

          for (int i = 0; i < n; i++) {
            sum += i;
          }

          Console.WriteLine("La somme des entiers de 1 à " + n + " est : " + sum);

          Console.WriteLine("Appuyez sur une touche pour quitter...");

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme