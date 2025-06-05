using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = CheckOut(10.5, 20.5, 30.5, 40.5, 50.5, 60.5, 70.5, 80.5, 90.5, 100.5);
            Console.WriteLine(total);
            Console.ReadKey();
        }
        // params sert à passer un nombre variable d'arguments à une fonction
        static double CheckOut(params double[] prices) {
            double total = 0;
            foreach (double price in prices) {
                total += price;
            }
            return total;
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme