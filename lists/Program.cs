using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = collection d'objets qui représente une liste d'éléments accessible par index
            // similaire à un tableau mais plus flexible
            // utilise System.Collections.Generic

            List<String> food = new List<String>();

            // ajoute un élément à la liste
            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            // supprime un élément de la liste
            food.Remove("Fries");
            // insère un élément à l'index 0 toujours à préciser en paramètre
            food.Insert(0, "Sushi");
            // Détermine le nombre d'élément de la liste
            Console.WriteLine(food.Count);

            // Détermine l'index d'un élément
            Console.WriteLine(food.IndexOf("Pizza"));

            // Détermine si un élément existe dans la liste
            Console.WriteLine(food.LastIndexOf("Sushi"));

            // Détermine si un élément existe dans la liste
            Console.WriteLine(food.Contains("Pizza"));

            // trie la liste
            food.Sort();
            // inverse la liste
            food.Reverse();
            // vide la liste
            food.Clear();
            // Détermine si la liste est vide et retourne un booléen
            Console.WriteLine(food.Count == 0);
            
            Console.ReadKey();
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
