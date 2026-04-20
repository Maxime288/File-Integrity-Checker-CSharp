using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FileIntegrityChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Titre de la fenêtre Windows
            Console.Title = "File Integrity Checker - Professional Edition";
            
            ShowHeader();

            // 2. Récupération du fichier
            Console.Write(" > Glissez-déposez le fichier à analyser : ");
            string? input = Console.ReadLine();
            string filePath = input?.Replace("\"", "") ?? "";

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                PrintStatus("Erreur : Fichier introuvable.", ConsoleColor.Red);
                return;
            }

            // 3. Calcul
            PrintStatus("Calcul en cours...", ConsoleColor.Cyan);
            string actualHash = CalculateSHA256(filePath);
            
            Console.WriteLine($"\n[INFO] Fichier : {Path.GetFileName(filePath)}");
            Console.WriteLine($"[HASH] SHA-256 : {actualHash}\n");

            // 4. Comparaison
            Console.Write(" > Comparer avec un hash connu ? (o/n) : ");
            string? reponse = Console.ReadLine()?.ToLower();

            if (reponse == "o")
            {
                Console.Write(" > Collez le hash attendu : ");
                string? expectedHash = Console.ReadLine()?.Trim();

                if (actualHash.Equals(expectedHash, StringComparison.OrdinalIgnoreCase))
                {
                    PrintStatus("Succès : Les hashs correspondent ! L'intégrité est garantie.", ConsoleColor.Green);
                }
                else
                {
                    PrintStatus("ALERTE : Le fichier a été modifié ou corrompu !", ConsoleColor.Red);
                }
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter...");
            Console.ReadKey();
        }

        // Méthode pour un affichage uniforme des messages
        static void PrintStatus(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n>>> {message}");
            Console.ResetColor();
        }

        static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║         FILE INTEGRITY CHECKER (v1.0)          ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        static string CalculateSHA256(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes) sb.Append(b.ToString("x2"));
                    return sb.ToString();
                }
            }
        }
    }
}