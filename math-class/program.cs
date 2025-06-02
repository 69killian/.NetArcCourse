using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           double x = 3;

           // c'est comme dire x xposant 2
           double a = Math.Pow(x, 2);
           Console.WriteLine(a);

           // c'est comme dire la racine carré de a
           double b = Math.Sqrt(a);
           Console.WriteLine(b);

           // c'est comme dire la valeur absolue de x
           double c = Math.Abs(x);
           Console.WriteLine(c);

           // c'est comme dire arrondir x
           double d = Math.Round(x);
           Console.WriteLine(d);

           // c'est comme dire arrondir x vers le haut
           double e = Math.Ceiling(x);
           Console.WriteLine(e);

           // c'est comme dire arrondir x vers le bas
           double f = Math.Floor(x);
           Console.WriteLine(f);
           
           // c'est comme dire le maximum entre x et y
           double g = Math.Max(x, y);
           Console.WriteLine(g);

           double h = Math.Min(x,y);
           Console.WriteLine(h);
           

            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code