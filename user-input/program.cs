using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre nom ?");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Tu as quel age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu as " + age + " ans");

            Console.WriteLine("Quel est ton Sexe ? (male/female)");
            String sexe = Console.ReadLine();

            if (sexe == "male") {
                Console.WriteLine("Tu es un homme");
            } else if (sexe == "female") {
                Console.WriteLine("Tu es une femme");
            }
            

            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code