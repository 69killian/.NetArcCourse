using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100) {
                Console.WriteLine("Are you even alive ?");
            } else if (age >= 18) {
                Console.WriteLine("You are an adult !");
            }
            else if (age < 0) {
                Console.WriteLine("You haven't been born yet !");
            } else {
                Console.WriteLine("You must be 18+ to sing up !");
            }

            Console.WriteLine("What is your name: ");
            String name = Console.ReadLine();

            if (name != "") {
                Console.WriteLine("Hello " + name);
            } else {
                Console.WriteLine("You didn't enter your name !");
            }

            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code






