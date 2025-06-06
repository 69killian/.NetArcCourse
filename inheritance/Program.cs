using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = la classe fille hérite des attributs et méthodes de la classe parente
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // les objets de la classe fille peuvent utiliser les méthodes de la classe parente
            // et ce sans même avoir eu besoin de les définir dans la classe fille
            Console.WriteLine(car.wheels);
            Console.WriteLine(bicycle.wheels);
            Console.WriteLine(boat.wheels);
            car.Go();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            bicycle.Go();

            Console.ReadKey();
        }
    }
    class Vehicle
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
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
