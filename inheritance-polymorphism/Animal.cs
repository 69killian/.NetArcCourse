using System;
using Chat;
using Chien;

namespace InheritancePolymorphism
{
    public class Animal
    {
        public string name;
        public string race;
        public int age;

        public Animal(string name, int age, string race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }

        public virtual void Crier()
        {
       
        }
    }
}
