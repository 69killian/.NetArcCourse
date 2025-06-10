using System;
using System.IO;
using LoggerNamespace;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Créer un chemin absolu pour le fichier de log
                string logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "logs");
                string logFile = Path.Combine(logDirectory, "application.log");

                // Créer l'instance du logger
                Logger logger = new Logger(logFile);

                bool continuer = true;
                while (continuer)
                {
                    Console.WriteLine("\n=== Logger Menu ===");
                    Console.WriteLine("1. Écrire un message INFO");
                    Console.WriteLine("2. Écrire un message WARNING");
                    Console.WriteLine("3. Écrire un message ERROR");
                    Console.WriteLine("4. Lire le fichier de log");
                    Console.WriteLine("5. Quitter");
                    Console.Write("\nChoisissez une option (1-5) : ");

                    string? choix = Console.ReadLine();

                    if (choix == "5")
                    {
                        continuer = false;
                        continue;
                    }

                    if (choix == "4")
                    {
                        logger.ReadLogs();
                        continue;
                    }

                    Console.Write("Entrez votre message : ");
                    string? message = Console.ReadLine();

                    if (string.IsNullOrEmpty(message))
                    {
                        Console.WriteLine("Le message ne peut pas être vide!");
                        continue;
                    }

                    switch (choix)
                    {
                        case "1":
                            logger.LogInfo(message);
                            Console.WriteLine("Message INFO enregistré!");
                            break;
                        case "2":
                            logger.LogWarning(message);
                            Console.WriteLine("Message WARNING enregistré!");
                            break;
                        case "3":
                            logger.LogError(message);
                            Console.WriteLine("Message ERROR enregistré!");
                            break;
                        default:
                            Console.WriteLine("Option invalide!");
                            break;
                    }

                    Console.WriteLine($"Les logs sont écrits dans : {logFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur est survenue : {ex.Message}");
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
