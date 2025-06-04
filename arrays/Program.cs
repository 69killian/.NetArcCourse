using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          // Pour créer un Array, on peut le faire de la façon suivante :
          String[] cars = {"BMW", "Ford", "Toyota", "Honda"};

          // assigner une valeur à un élément, on peut le faire de la façon suivante :
          String[] cars2 = new String[4];
          cars2[0] = "Opel";
          cars2[1] = "Toyota";
          cars2[2] = "BMW";
          cars2[3] = "Mercedes";

          // Pour modifier la valeur d'un élément, on peut le faire de la façon suivante :
          cars[0] = "Mercedes";

          
          // Pour afficher tous les éléments de l'Array, on peut le faire de la façon suivante :
          for (int i = 0; i < cars.Length; i++) {
            Console.WriteLine(cars[i]);
          }

          // Meilleure approche
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