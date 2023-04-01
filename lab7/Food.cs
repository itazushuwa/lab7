using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("I am food.");
        }
    }
    public class Meat : Food
    {
        public override void Eat()
        {
            Console.WriteLine("I am meat.");
        }
    }

    public class Vegetables : Food
    {
        public override void Eat()
        {
            Console.WriteLine("I am vegetables.");
        }
    }
}
