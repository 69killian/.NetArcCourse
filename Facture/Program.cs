using System;
using FactureNamespace;
using FactureAbonnementNamespace;
using FactureProduitNamespace;
using FactureServiceNamespace;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Facture[] factures = new Facture[3];
            factures[0] = new FactureAbonnement(54748995265, "Abonnement", 100.0m);
            factures[1] = new FactureProduit(54748995266, "Produit", 50.0m);
            factures[2] = new FactureService(54748995267, "Service", 200.0m);

            foreach (Facture facture in factures)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(facture);
                Console.WriteLine("Montant TTC: " + facture.CalculerMontantTTC());
                Console.WriteLine("--------------------------------");
            }

            // ou plymorphisme avec une liste

            List<Facture> facturesList = new List<Facture>();
            facturesList.Add(new FactureAbonnement(54748995265, "Abonnement", 100.0m));
            facturesList.Add(new FactureProduit(54748995266, "Produit", 50.0m));
            facturesList.Add(new FactureService(54748995267, "Service", 200.0m));

            foreach (Facture facture in facturesList)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(facture);
                Console.WriteLine("Montant TTC: " + facture.CalculerMontantTTC());
                Console.WriteLine("--------------------------------");
            }

            Console.ReadKey();
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
