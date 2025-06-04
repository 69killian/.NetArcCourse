using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          // Pour créer un Array, on peut le faire de la façon suivante :
          String[] cars = {"BMW", "Ford", "Toyota", "Honda"};

          // pour chaque élément de l'Array, on peut le faire de la façon suivante :
          foreach(string car in cars) {
            Console.WriteLine(car);
          }

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme