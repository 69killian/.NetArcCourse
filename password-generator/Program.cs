using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the password generator");
            int maxGenerations = 3;
            int generationCount = 0;

            while (generationCount < maxGenerations)
            {
                Console.WriteLine("How many characters do you want in your password? (min 4, max 20)");
                int howManyCharacters = Convert.ToInt32(Console.ReadLine());

                while (howManyCharacters < 4 || howManyCharacters > 20)
                {
                    Console.WriteLine("Invalid input. Try again...");
                    Console.WriteLine("How many characters do you want in your password? (min 4, max 20)");
                    howManyCharacters = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Do you want letters in your password? (yes/no)");
                string lettersInput = Console.ReadLine().ToLower();
                bool includeLetters = lettersInput == "yes" || lettersInput == "y";

                Console.WriteLine("Do you want numbers in your password? (yes/no)");
                string numbersInput = Console.ReadLine().ToLower();
                bool includeNumbers = numbersInput == "yes" || numbersInput == "y";

                Console.WriteLine("Do you want special characters in your password? (yes/no)");
                string specialCharactersInput = Console.ReadLine().ToLower();
                bool includeSpecialCharacters = specialCharactersInput == "yes" || specialCharactersInput == "y";

                string password = "";
                string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string numbers = "0123456789";
                string specialCharacters = "!@#$%^&*()";
                string allowedCharacters = "";

                if (includeLetters)
                {
                    allowedCharacters += letters;
                }
                if (includeNumbers)
                {
                    allowedCharacters += numbers;
                }
                if (includeSpecialCharacters)
                {
                    allowedCharacters += specialCharacters;
                }

                if (string.IsNullOrEmpty(allowedCharacters))
                {
                    Console.WriteLine("You must select at least one type of character for your password.");
                    continue;
                }

                Random random = new Random();

                for (int i = 0; i < howManyCharacters; i++)
                {
                    password += allowedCharacters[random.Next(allowedCharacters.Length)];
                }

                Console.WriteLine("Your password is: " + password);
                generationCount++;

                if (generationCount < maxGenerations)
                {
                    Console.WriteLine("Do you want to generate another password? (yes/no)");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes" && response != "y")
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Thank you for using the password generator!");
            Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme