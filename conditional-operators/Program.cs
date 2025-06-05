using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           double temperature = 20;
           string message;
           message = (temperature >= 15) ? "It is warm" : "It is cold";
           Console.WriteLine(message);

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme