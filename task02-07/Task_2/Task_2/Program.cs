using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        interface ISound 
        {
            void MakeSound();
        }
        public abstract class Animal
        {
            public string Name { get; set; }

            public Animal(string name) { this.Name = name; }
            public abstract void Eat();
            public void Sleep() { Console.WriteLine($"{Name} is Sleeping."); }
        }
        public class Dog: Animal , ISound
        {
            public Dog(string name) : base(name) { }
            public void MakeSound() { Console.WriteLine("The dog say woof woof"); }
            public override void Eat() { Console.WriteLine($"The Dog is Eating beef "); } 
        }
        public class Cat : Animal, ISound
        {
            public Cat(string name) : base(name) { }
            public void MakeSound() { Console.WriteLine("The Cat say meaw"); }
            public override void Eat() { Console.WriteLine($"The Dog is Eating chicken "); }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat("kitty");
            cat.MakeSound();
            cat.Eat();
            cat.Sleep();
            Dog dog = new Dog("Ben");
            dog.MakeSound();
            dog.Eat();
            dog.Sleep();
        }
    }
}
