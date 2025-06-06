using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] garage = new Car[3];

            Car car = new Car("Toyota");
            Car car2 = new Car("BMW");
            Car car3 = new Car("Mercedes");

            garage[0] = car;
            garage[1] = car2;
            garage[2] = car3;

            // autre façon de créer un tableau de voitures avec moins de lignes de code
            Car[] garage = {new Car("Toyota"), new Car("BMW"), new Car("Mercedes")};

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            // affichertoutes les voitures dans le garage
            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    // Car hérite de la classe Vehicle
    class Car 
    {
        public String model;
        
        public Car(String model)
        {
            this.model = model;
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
