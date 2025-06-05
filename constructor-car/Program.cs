using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car("Chevy", "Corvette", 2022, "blue");
           Car car2 = new Car("Ford", "Mustang", 2023, "red");

           Car.Start();
           Car.Stop();
           Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color) {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public static void Start() {
            Console.WriteLine("The car starts");
        }
        public static void Stop() {
            Console.WriteLine("The car stops");
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme