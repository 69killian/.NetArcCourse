using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

          // Boucle qui affiche les nombres impairs de 1 à 10
          for(int i = 1; i <= 10; i+=2) {
            Console.WriteLine(i);
          }

          // Boucle qui affiche les nombres de 10 à 1
          for (int i = 10; i > 0; i--) {
            Console.WriteLine(i);
          }

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme