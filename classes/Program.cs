using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Messages.Hello();
          Messages.Waiting();
          Messages.Bye();
           
           Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme