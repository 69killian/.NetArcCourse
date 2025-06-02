using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            friends++;
            friends += 1;
            friends = friends + 1;

            friends--;
            friends -= 1;
            friends = friends - 1;

            friends *= 2;
            friends = friends * 2;

            friends /= 2;
            friends = friends / 2;
            
            

            Console.WriteLine(friends.GetType());
           
            Console.ReadKey();
        }
    }
}

// .\run_csharp
// pour lancer le code