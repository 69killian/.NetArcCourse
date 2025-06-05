using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // array classique
           String[] ford = {"Mustang", "F-150", "Explorer", "Escape", "Edge"};
           String[] chevrolet = {"Camaro", "Corvette", "Bolt", "Equinox", "Traverse"};
           String[] jeep = {"Wrx", "Compass", "Cherokee", "Grand Cherokee", "Renegade"};
           
           // On peut avoir accès à un élément en spécifiant les index comme si c'était une matrice
           String[,] parkingLot = {
            {"Mustang", "F-150", "Explorer", "Escape", "Edge"},
            {"Camaro", "Corvette", "Bolt", "Equinox", "Traverse"},
            {"Wrx", "Compass", "Cherokee", "Grand Cherokee", "Renegade"}
           };

           // On peut modifier un élément en spécifiant les index comme si c'était une matrice
           parkingLot[0, 2] = "Fusion";
           parkingLot[2, 0] = "Tacoma";

           foreach (String car in parkingLot)
           {
            Console.WriteLine(car);
           }

           // On peut utiliser une boucle for pour parcourir les éléments de l'array
           //nested loop
           //La boucle va afficher dans le même ordre que l'array qu'on a créé
           for (int i = 0; i < parkingLot.GetLength(0); i++)
           {
            for (int j = 0; j < parkingLot.GetLength(1); j++)
            {
                Console.Write(parkingLot[i, j] + " ");
            }
            Console.Write();
           }
           
           
           
           Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme