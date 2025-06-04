using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          double x;
          double y;
          double result;

          Console.WriteLine("Enter a number 1: ");
          x = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter number 2: ");
          y = Convert.ToDouble(Console.ReadLine());

          result = Multiply(x, y);

          Console.WriteLine("The result is: " + result);

          Console.ReadKey();
        }

        // tant que la méthode ne retourne pas de valeur, elle est de type void
        // si la méthode retourne une valeur, elle est de type int, double, char, etc.
        // on en retourne une valeur que si on a créé une variable qui stocke la valeur à retourner
        static double Multiply(double x, double y) 
        {
          return x * y;
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme