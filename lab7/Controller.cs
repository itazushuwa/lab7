using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public class Controller
    {
        private List<Animal> animals;

        public Controller()
        {
            this.animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
        }

        public void FeedAnimals()
        {
            Console.WriteLine("Feeding animals:");
            foreach (Animal animal in this.animals)
            {
                animal.Eat();
            }
        }
        public void SleepingAnimals()
        {
            Console.WriteLine("Animals going to sleep:");
            foreach (Animal animal in this.animals)
            {
                animal.Sleep();
            }

        }
        public void VoiceAnimals()
        {
            Console.WriteLine("Animals voicing jestko:");
            foreach (Animal animal in this.animals)
            {
                animal.Voice();
            }
        }

    }
}