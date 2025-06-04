using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

          singHappyBirthday("Marc", 21);
          singHappyBirthday("John", 20);

          Console.ReadKey();
        }
        
        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
         Console.WriteLine("Happy Birthday!");
         Console.WriteLine("Happy Birthday to you!");
         Console.WriteLine("Happy Birthday to you " + birthdayBoy + "!");
         Console.WriteLine("Happy Birthday to you!");
         Console.WriteLine("Happy Birthday to you!");
         Console.WriteLine("You are " + yearsOld + " years old now!");
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme