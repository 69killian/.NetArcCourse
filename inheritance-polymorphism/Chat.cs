using System;
using InheritancePolymorphism;

namespace Chat
{
    public class Cat : Animal
    {
        
        public Cat(string name, int age, string race) : base(name, age, race)
        {
            
        }

          public override string ToString()
        {
            return $"Name: {name}\nAge: {age}\nRace: {race}";
        }

        public override void Crier()
        {
            Console.WriteLine($"This {race} makes a sound");
        }
    }
    
}
