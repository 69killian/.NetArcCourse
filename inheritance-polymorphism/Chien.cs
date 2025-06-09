using System;
using InheritancePolymorphism;

namespace Chien
{
     public class Dog : Animal
    {
        public Dog(string name, int age, string race) : base(name, age, race)
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
