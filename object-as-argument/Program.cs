using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Red");
            // on copie l'objet car
            Car car2 = Copy(car);

            // on change la couleur de l'objet car
            ChangeColor(car, "Blue");

            // on affiche la couleur de l'objet car et car2
            Console.WriteLine(car2.color + " " + car2.model);

            // on change la couleur de l'objet car2
            ChangeColor(car2, "Green");

            // on affiche la couleur de l'objet car et car2
            Console.WriteLine(car.color + " " + car2.color);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        // ce code est un exemple de copie d'objet
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    // Car hérite de la classe Vehicle
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }

}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
