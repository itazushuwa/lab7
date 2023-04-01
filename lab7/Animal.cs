using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("I am an animal.");
        }

        public virtual void Eat()
        {
            Console.WriteLine("I eat food.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("I'm sleeping brou.");
        }
    }
    public class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Horse : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cjokkkkk!");
        }
    }
}
