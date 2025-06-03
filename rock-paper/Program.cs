using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain) {

                player = "";
                computer = "";
                String response = "";

                while (player != "r" && player != "p" && player != "s") {
                    Console.WriteLine("Invalid input. Try again...");
                    Console.WriteLine("Rock, Paper, Scissors!");
                    Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
                    player = Console.ReadLine();
                }

                int computerChoice = random.Next(1, 4);
                switch (computerChoice) {
                    case 1:
                        computer = "r";
                        break;
                    case 2:
                        computer = "p";
                        break;
                    case 3:
                        computer = "s";
                        break;
                }

                Console.WriteLine("You chose " + player);
                Console.WriteLine("Computer chose " + computer);

                switch (player) {
                    case "r":
                        if (computer == "r") {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "p") {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "s") {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "p":
                        if (computer == "r") {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "p") {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "s") {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "s":
                        if (computer == "r") {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "p") {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "s") {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? (yes/no)");
                response = Console.ReadLine() ?? string.Empty;
                response = response.ToLower();

                if (response == "yes" || response == "y") {
                    playAgain = true;
                }
                else {
                    playAgain = false;
                }

                Console.WriteLine("Thanks for playing!");
            }

            Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme