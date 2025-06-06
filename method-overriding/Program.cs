using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding = une méthode dans une classe fille peut remplacer une méthode dans une classe parente
            // la method doit etre abstraite, virtual ou override
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.ReadKey();
        }
    }
   
    class Animal
    {
        // virtual = permet de remplacer la méthode dans la classe fille
       public virtual void Speak()
       {
            Console.WriteLine("This animal makes a sound");
       }
    }

    class Dog : Animal
    {
        // override = remplace la méthode dans la classe parente
       public override void Speak()
       {
            Console.WriteLine("Woof!");
       }
    }

    class Cat : Animal
    {
        // override = remplace la méthode dans la classe parente
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
