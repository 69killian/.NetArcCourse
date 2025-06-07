using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum est un type de données qui permet de définir un ensemble de constantes
            // pas besoin de créer des variables pour les constantes puisqu'elles sont déjà définies dans l'enum

            Console.WriteLine(Planets.Mercury + "is the closest planet to the sun" + " and the " + (int)Planets.Mercury + "th planet");

            String name = Planets.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(radius);
            Console.WriteLine("The radius of the planet " + name + " is " + radius + " km");
            Console.WriteLine("The volume of the planet " + name + " is " + volume + " km^3");

            Console.ReadKey();
        }
        public static double Volume(int radius)
        {
            return (4 / 3) * Math.PI * Math.Pow((int)radius, 3);
        }
    }
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune,
    }

    enum PlanetRadius
    {
        Mercury = 2440,
        Venus = 6052,
        Earth = 6378,
        Mars = 3396,
        Jupiter = 71492,
        Saturn = 60268,
        Uranus = 25559,
        Neptune = 24764,
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
