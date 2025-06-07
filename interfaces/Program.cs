using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // une interface est un contrat entre une classe et une autre classe
           // une classe implémentant une interface doit implémenter tous les membres de l'interface
           // une interface peut contenir des méthodes, des propriétés, des événements, etc.
           // une interface ne peut pas contenir de constructeur
           // une interface ne peut pas contenir de champ
           // une interface ne peut pas contenir de méthode implémentée
           Rabit rabit = new Rabit();
           rabbit.Flee();

           Hawk hawk = new Hawk();
           hawk.Hunt();

           Fish fish = new Fish();
           fish.Flee();
           fish.Hunt();

            Console.ReadKey();
        }
    }
    // interface pour les proies
    // le nom contient un "I" en majuscule parce que c'est une convention d'interface
    interface IPrey
    {
        void Flee();
    }

    // interface pour les prédateurs
    interface IPredator
    {
        void Hunt();
    }

    class Rabit: IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit is fleeing");
        }
    }

    class Hawk: IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is hunting");
        }
    }

    class Fish: IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish is fleeing");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is hunting");
        }
    }

}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
