using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // avec int, on peut stocker des nombres entiers
            // avec double, on peut stocker des nombres décimaux
            // avec bool, on peut stocker des valeurs booléennes (true ou false)
            // avec char, on peut stocker un seul caractère
            // avec String (toujours en majuscule), on peut stocker une chaîne de caractères

            int x; // declaration
            x = 123; // initialisation

            int y = 321; // declaration et initialisation

            int z = x + y;

            int age = 21;
            double price = 300.25;
            bool test = true;
            char symbol = '@';
            String name = "DAREDEVIL";

            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("The price is " + price);
            Console.WriteLine("The test is " + test);
            Console.WriteLine("The symbol is " + symbol);
            Console.WriteLine("The name is " + name);

            String username = symbol + name;

            Console.WriteLine("The username is " + username);

            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code