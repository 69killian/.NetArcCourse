using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = conversion d'un type de données en un autre type.
            double a = 3.14;
            // Convert.ToInt32() = conversion d'un double en un int.
            int b = Convert.ToInt32(a);

            // Convert.ToDouble() = conversion d'un int en un double.
            int c = 123;
            // Convert.ToDouble(c) + 0.1 = conversion d'un int en un double et ajout d'un 0.1.  
            double d = Convert.ToDouble(c) + 0.1;

            // Convert.ToString() = conversion d'un int en un String.
            int e = 321;

            String f = Convert.ToString(e);

            String g = "%";
            // Convert.ToChar() = conversion d'un String en un char.
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            // pour afficher le type de la variable
            Console.WriteLine(a.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());
            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code