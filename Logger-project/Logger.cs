using System;
using System.IO;

namespace LoggerNamespace
{
    public class Logger
    {
        private readonly string logFilePath;

        public Logger(string logFilePath)
        {
            // Vérifier si le chemin est null ou vide
            if (string.IsNullOrWhiteSpace(logFilePath))
            {
                throw new ArgumentException("Le chemin du fichier de log ne peut pas être vide", nameof(logFilePath));
            }

            // Convertir en chemin absolu si c'est un chemin relatif
            this.logFilePath = Path.GetFullPath(logFilePath);
            
            // Créer le répertoire du fichier de log s'il n'existe pas
            string? directory = Path.GetDirectoryName(this.logFilePath);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private void WriteToLogFile(string logType, string message)
        {
            try
            {
                // Formater le message avec la date et le type
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string logEntry = $"[{timestamp}] [{logType}] {message}";

                // Écrire dans le fichier en mode append et gérer la fermeture automatique
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de l'écriture dans le fichier de log : {e.Message}");
                throw; // Propager l'erreur pour que l'appelant puisse la gérer
            }
        }

        public void LogInfo(string message)
        {
            WriteToLogFile("INFO", message);
        }

        public void LogWarning(string message)
        {
            WriteToLogFile("WARNING", message);
        }

        public void LogError(string message)
        {
            WriteToLogFile("ERROR", message);
        }

        public void ReadLogs()
        {
            try
            {
                if (File.Exists(logFilePath))
                {
                    // Lire toutes les lignes du fichier de log
                    string[] lines = File.ReadAllLines(logFilePath);
                    // Vérifier si le fichier est vide
                    if (lines.Length == 0)
                    {
                        // Afficher un message si le fichier est vide
                        Console.WriteLine("Le fichier de log est vide.");
                        return;
                    }

                    Console.WriteLine("\n=== Contenu du fichier log ===");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("============================");
                }
                else
                {
                    Console.WriteLine("Le fichier de log n'existe pas encore.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier de log : {e.Message}");
                throw;
            }
        }
    }
}
