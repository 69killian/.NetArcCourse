using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bienvenue dans notre Zoo !");
            Console.WriteLine("Vos animaux vont être transférés dans un établissment spécialisé");
            Console.WriteLine("Nous vous demandons de renseigner le nombre d'animaux que vous souhaitez transférer");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Entrez le nombre d'animaux :");
            if (!int.TryParse(Console.ReadLine(), out int nombreAnimaux))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                return;
            }

            Animal[] animals = new Animal[nombreAnimaux];
            for (int i = 0; i < nombreAnimaux; i++)
            {
                Console.WriteLine("Entrez le nom de l'animal :");
                string nom = Console.ReadLine() ?? "Inconnu";
                Console.WriteLine("Entrez l'age de l'animal :");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Entrée invalide. L'âge sera défini à 0.");
                    age = 0;
                }
                Console.WriteLine("Entrez la race de l'animal :");
                string race = Console.ReadLine() ?? "Inconnu";
                Console.WriteLine("Entrez le refuge de l'animal :");
                string refugeLocal = Console.ReadLine() ?? "Inconnu";

                // Alternating between Dog and Cat for demonstration
                if (i % 2 == 0)
                {
                    animals[i] = new Dog(nom, age, "Dog", race, refugeLocal);
                }
                else
                {
                    animals[i] = new Cat(nom, age, "Cat", race, refugeLocal);
                }
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Animaux avant tri :");
            foreach (Animal animal in animals)
            {
                animal.AfficherInfos();
                animal.FaireDuBruit();
            }
            Console.WriteLine("--------------------------------");

            TrierAnimaux(animals);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Animaux après tri :");
            foreach (Animal animal in animals)
            {
                animal.AfficherInfos();
                animal.FaireDuBruit();
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Entrez le refuge de destination pour ces animaux :");
            string refuge = Console.ReadLine() ?? "Inconnu";

            foreach (Animal animal in animals)
            {
                TransfertAnimal(animal, refuge);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Animaux après transfert :");
            foreach (Animal animal in animals)
            {
                animal.AfficherInfos();
                animal.FaireDuBruit();
            }
            Console.ReadKey();
        }

        public static void TrierAnimaux(Animal[] animals)
        {
            Array.Sort(animals, (a, b) => a.Age.CompareTo(b.Age));
        }

        public static void TransfertAnimal(Animal a, string nouveauRefuge)
        {
            a.SetRefuge(nouveauRefuge);
        }
    }

    abstract class Animal
    {
        private string name;
        private int age;
        private string species;
        private string refuge;

        public Animal(string name, int age, string species, string refuge)
        {
            this.name = name;
            this.age = age;
            this.species = species;
            this.refuge = refuge;
        }

        public int Age
        {
            get { return age; }
        }

        public abstract void FaireDuBruit();

        public override string ToString()
        {
            return "Name: " + name + ", Age: " + age + ", Species: " + species + ", Refuge: " + refuge;
        }

        public virtual void AfficherInfos()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Species: " + species + ", Refuge: " + refuge);
        }

        public void SetRefuge(string nouveauRefuge)
        {
            refuge = nouveauRefuge;
        }
    }

    class Dog : Animal
    {
        private string race;

        public Dog(string name, int age, string species, string race, string refuge) : base(name, age, species, refuge)
        {
            this.race = race;
        }

        public override void FaireDuBruit()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        private string pelage;

        public Cat(string name, int age, string species, string pelage, string refuge) : base(name, age, species, refuge)
        {
            this.pelage = pelage;
        }

        public override void FaireDuBruit()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
