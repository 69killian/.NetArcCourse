using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Tesla");
            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        // getters et setters automatiques
        // Plus besoin de créer des méthodes getters et setters
        // Plus besoin de créer des variables privées
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
