using System;
using InheritancePolymorphism;
using Chat;
using Chien;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Miaou", 5, "Cat");
            Console.WriteLine(cat);
            cat.Crier();

            Dog dog = new Dog("Rex", 10, "Dog");
            Console.WriteLine(dog);
            dog.Crier();

            // Polymorphisme c'est le fait d'utiliser une classe parente pour créer un objet de la classe enfant
            Animal[] animaux = new Animal[2];
            animaux[0] = cat;
            animaux[1] = dog;

            foreach (Animal animal in animaux)
            {
                animal.Crier();
            }

            Console.ReadKey();
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
