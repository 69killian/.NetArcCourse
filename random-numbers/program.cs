using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // c'est un objet de la classe Random de C#
           Random random = new Random();

           // c'est comme dire un nombre aléatoire entre 1 et 21
           int x = random.Next(1, 21);

           // c'est le random pour les nombres décimaux
           double num = random.NextDouble();

           Console.WriteLine(x);
           Console.WriteLine(num);
           
            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code






