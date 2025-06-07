using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic est un type de données qui permet de définir un type de données sans préciser le type de données

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            String[] stringArray = { "Hello", "World", "Generic", "Type", "Data" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);
            Console.ReadKey();
        }
        public static void DisplayElements<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
