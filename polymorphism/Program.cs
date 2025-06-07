using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism = plusieurs formes. C'est la capacité d'un objet a être de  plusieurs types
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // on peut créer un tableau de type Vehicle et y ajouter des objets de type Car, Bicycle et Boat
            // Vehicle est la classe mère de Car, Bicycle et Boat on la définit comme un tableau de type Vehicle
            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }
     class Vehicle
     {
        public virtual void Go()
        {
            
        }
     }

     class Car: Vehicle
     {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
     }

     class Bicycle: Vehicle
     {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
     }

     class Boat: Vehicle
     {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
     }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
