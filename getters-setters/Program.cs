using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200);
            car.Speed = 100;
            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            this.speed = speed;
        }

        public int Speed
        {
            // get = récupère la valeur de la variable
            get { return speed; }
            // set = définit la valeur de la variable
            set 
            {
                if (speed > 500) 
                {
                    speed = 500;
                } 
            else 
            { 
                speed = value; 
            }
            }
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
