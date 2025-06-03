using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre de nombres à générer (min 2, max 10) :");
            int n = int.Parse(Console.ReadLine());

            while (n < 2 || n > 10) {
                Console.WriteLine("Nombre invalide. Veuillez entrer un nombre entre 2 et 10.");
                n = int.Parse(Console.ReadLine());
            }

            int[] numbers = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++) {
                numbers[i] = random.Next(1, 100);
                Console.WriteLine("Le nombre généré est : " + numbers[i]);
            }
            int sum = 0;

            foreach (int number in numbers) {
                if (number % 2 == 0) {
                    sum += number;
                }
            }
            Console.WriteLine("Et La somme des nombres pairs est : " + sum);
            Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme