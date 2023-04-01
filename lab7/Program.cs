using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            Animal cat = new Cat();
            Animal dog = new Dog();
            Animal horse = new Horse();
            Animal cat2 = new Cat();
            Animal horse2 = new Horse();
            Animal dog2 = new Dog();

            controller.AddAnimal(cat);
            controller.AddAnimal(dog);
            controller.AddAnimal(horse);
            controller.AddAnimal(cat2);
            controller.AddAnimal(dog2);
            controller.AddAnimal(horse2);

            controller.FeedAnimals();
            controller.SleepingAnimals();
            controller.VoiceAnimals();
        }
    }
} 