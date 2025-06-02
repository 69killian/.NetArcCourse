using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           String fullName = "Killian Codes";
           String phoneNumber = "123-456-7890";

           // c'est comme dire mettre tout en majuscule
           fullName = fullName.ToUpper();
           Console.WriteLine(fullName);

           // c'est comme dire mettre tout en minuscule
           fullName = fullName.ToLower();
           Console.WriteLine(fullName);

           // c'est comme dire remplacer un caractère par un autre (remplace le - par /)
           phoneNumber = phoneNumber.Replace("-", "/");
           Console.WriteLine(phoneNumber);

           // c'est comme dire insérer un caractère à un endroit précis
           String userName = fullName.Insert(0, "@");
           Console.WriteLine(userName);

           // c'est comme dire compter le nombre de caractères
           int fullNameLength = fullName.Length;
           Console.WriteLine(fullNameLength);

           // c'est comme dire prendre seulement le prénom
           String firstName = fullName.Substring(0, 6);
           Console.WriteLine(firstName);

           // c'est comme dire prendre seulement le nom
           String lastName = fullName.Substring(7);
           Console.WriteLine(lastName);
           
           
           
           
           
           
           
           
           
           
            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code






