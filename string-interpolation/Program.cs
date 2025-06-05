using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           String firstName = "John";
           String lastName = "Doe";
           int age = 25;

            // Si je met un dollar devant les variables, je peux les mettre dans le string sans concaténer
           Console.WriteLine($"Nom : {lastName}, Prénom : {firstName}, Age : {age}");

           Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme