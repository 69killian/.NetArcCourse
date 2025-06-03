using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("How many rows? ");
         int rows = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("How many columns? ");
         int columns = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("What symbol? ");
         String symbol = Console.ReadLine();  

         for (int i = 0; i < rows; i++) {
          for (int j = 0; j < columns; j++) {
            Console.Write(symbol);
          }
          Console.WriteLine();
         }

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme