using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory defaultAnimalFactory = new DefaultAnimalFactory();
            IFactory randomAnimalFactory = new RandomAnimalFactory();

            IAnimal dog = defaultAnimalFactory.CreateAnimal("dog");
            IAnimal cat = defaultAnimalFactory.CreateAnimal("cat");
            IAnimal duck = defaultAnimalFactory.CreateAnimal("duck");

            IAnimal animal = randomAnimalFactory.CreateAnimal(null);

            dog.Eat();
            dog.Sleep();

            cat.Eat();
            cat.Sleep();

            duck.Eat();
            duck.Sleep();

            animal.Eat();
            animal.Sleep();

            Console.ReadLine();
        }
    }
}
