using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter your name: ");
           String name = Console.ReadLine();

            // Répète la boucle tant que le nom n'est pas entré
           while (name == "") {
            Console.WriteLine("You did not enter your name");
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
           }

           Console.WriteLine("Hello " + name);
           
            Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme