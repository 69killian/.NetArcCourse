using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // abstract classes = une classe abstraite est une classe qui ne peut pas être instanciée
           // elle permet d'indiquer les composants manquants ou son implémentation incomplète

           Car car = new Car();
           Bicycle bicycle = new Bicycle();
           Boat boat = new Boat();
           Vehicle vehicle = new Vehicle();

           Console.WriteLine(car.maxSpeed);
           Console.WriteLine(bicycle.maxSpeed);
           Console.WriteLine(boat.maxSpeed);

            Console.ReadKey();
        }
    }
    abstract class Vehicle
    {
        public int speed = 0;

        // cette méthode est héritée par les classes filles
        // on peut l'utiliser avec les objets de ces classes
        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    // Car hérite de la classe Vehicle
    class Car : Vehicle
    {
        public int wheels = 4;
        public int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public int maxSpeed = 20;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        public int maxSpeed = 100;
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
