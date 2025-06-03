using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What's the temperature outside? c");
           double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25) {
                Console.WriteLine("It is warm outside");
            } else if (temp <= -50 || temp >= 50) {
                Console.WriteLine("Don't go outside");
            }
            Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme