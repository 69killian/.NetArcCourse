using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write() = écrit dans la même ligne
            Console.Write("Hello");
            // WriteLine() = écrit dans une nouvelle ligne
            Console.WriteLine("Hello");
            /*
            * this is 
            * multiline comment
            */

            // \n = new line
            // \t = tab
            // \b = backspace
            Console.WriteLine("Killian\nKillian\nKillian");
            Console.WriteLine("\tKillian");
            Console.WriteLine("Killian\b Marty");

            // pause le programme
            Console.ReadKey();
        }
    }
}

// .\run_csharp. 
// pour lancer le code