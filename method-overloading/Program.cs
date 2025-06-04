using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          // les methods peuvent avoir le même nom si elles ont des paramètres différents
          // les paramètres sont les variables entre parenthèses dans la définition de la méthode
          // les paramètres sont séparés par des virgules
          // les paramètres sont de types différents
          // les paramètres sont dans l'ordre et le type
          double total;

          total = Multiply(1, 2, 3);
          Console.WriteLine(total);
          Console.ReadKey();
         
        }

        // tant que la méthode ne retourne pas de valeur, elle est de type void
        // si la méthode retourne une valeur, elle est de type int, double, char, etc.
        // on en retourne une valeur que si on a créé une variable qui stocke la valeur à retourner
        static double Multiply(double x, double y) 
        {
          return a * b;
        }

        static double Multiply(double a, double b, double c) 
        {
          return a * b * c;
        }
        

    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme