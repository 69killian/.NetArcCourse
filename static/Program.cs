using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Toyota", 10000);
            Car car2 = new Car("Mustang", 10000);
            Car car3 = new Car("BMW", 10000);

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
        public class Car
        {
            String model;
            public static int numberOfCars;

            public Car(String model, int numberOfCars)
            {
                this.model = model;
                numberOfCars++;
            }

            public static void StartRace()
            {
                Console.WriteLine("Starting race...");
            }
        }
    }
}
