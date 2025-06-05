using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancier un objet
            // comme le Random random = new Random();
          Human human1 = new Human();
          Human human2 = new Human();

          human1.name = "Rick";
          human1.age = 65;

          human2.name = "Morty";
          human2.age = 16;

          human1.Eat();
          human1.Sleep();

          human2.Eat();
          human2.Sleep();
           
           Console.ReadKey();
        }
    }
    class Human 
    {
        // public rend accessible à d'autres classes ce qui est dedans
        // les variables sont des champs que l'objet possède
        public String name;
        public int age;

        // les méthodes sont des actions que l'objet peut faire
        public void Eat()
        {
            Console.WriteLine(name + 'is eating');
        }
        public void Sleep()
        {
            Console.WriteLine(name + 'is sleeping');
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme