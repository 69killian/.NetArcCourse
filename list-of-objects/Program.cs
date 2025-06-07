using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste d'objets
            List<Player> players = new List<Player>();

            // Ajout d'objets à la liste
            players.Add(new Player("John"));
            players.Add(new Player("Jane"));
            players.Add(new Player("Karen"));

            // Affichage de la liste
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
    

    class Player 
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return "Player: " + username;
        }
    }

}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
