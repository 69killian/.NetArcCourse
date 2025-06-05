using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // les codes dangereux sont capturés par le try catch
          try {
            Console.WriteLine("Entrez un nombre :");
            int nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vous avez entré : " + nombre);
          } catch (Exception e) {
            Console.WriteLine("Erreur : " + e.Message);
          } finally {
            Console.WriteLine("Merci de votre participation");
          }

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme