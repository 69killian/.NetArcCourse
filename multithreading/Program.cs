using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multithreading est un processus qui permet de faire plusieurs tâches en même temps
            
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete");

            Console.ReadKey();
        }
        public static void CountDown(String name)
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + " : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete");
        }
        public static void CountUp(String name)
        {
            for(int i = 0; i <= 10; i++)
            {
                // Thread.Sleep(1000) est une méthode qui permet de mettre en pause le thread pour 1 seconde
                Console.WriteLine(name + " : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete");
        }
    }
}
// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme
