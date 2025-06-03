using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();
          bool playAgain = true;
          int min = 1;
          int max = 100;
          int guess;
          int number;
          int guesses;
          String response;

          while (playAgain) {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);

            while (guess != number) {
              Console.WriteLine("Guess a number between " + min + " and " + max + ": ");
              guess = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Guess: " + guess);

              if (guess > number) {
                Console.WriteLine(guess + " is too high!");
              }
              else if (guess < number) {
                Console.WriteLine(guess + " is too low!");
              }
              guesses++;
            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("Guesses: " + guesses);

            Console.WriteLine("Would you like to play again? (yes/no)");
            response = Console.ReadLine() ?? string.Empty;
            response = response.ToLower();

            if (response == "yes" || response == "y") {
              playAgain = true;
            }
            else {
              playAgain = false;
            }
          }

          Console.WriteLine("Thanks for playing!");
         
         

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme