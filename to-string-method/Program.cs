using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = fonction quiretourne une chaîne de caractères qui représente l'objet
            
            Car car = new Car("Toyota", "Corolla", "Red", 2020);

            // on est pas obligé d'appeler la méthode ToString()
            // car elle est appelée automatiquement lorsqu'on utilise Console.WriteLine()
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
   
    class Car
    {
        public String make;
        public String model;
        public String color;
        int year;

        public Car(String make, String model, String color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        // override = remplace la méthode dans la classe parente de ToString()
        public override string ToString()
        {
            // retourne une chaîne de caractères qui représente l'objet
            return "Make: " + make + " Model: " + model + " Color: " + color + " Year: " + year;
        }
        
        
        
        
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
